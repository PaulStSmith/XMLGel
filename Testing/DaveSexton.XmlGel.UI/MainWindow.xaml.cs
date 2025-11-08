using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;
using DaveSexton.XmlGel.Maml;
using Microsoft.Win32;

namespace DaveSexton.XmlGel.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private static readonly string dialogDefaultFolder = GetTestDataFolder();

		private bool IsOutputVisible
		{
			get
			{
				return structureTextBox.Visibility == Visibility.Visible;
			}
		}

		private bool updating;
		private string file;

		private static string GetTestDataFolder()
		{
			// Try to find test data in the output directory first
			var assemblyLocation = Assembly.GetExecutingAssembly().Location;
			var assemblyDir = Path.GetDirectoryName(assemblyLocation);
			var testDataPath = Path.Combine(assemblyDir, "Maml");
			
			if (Directory.Exists(testDataPath))
			{
				return testDataPath;
			}
			
			// Fallback: try to find the test project relative to assembly location
			var currentDir = assemblyDir;
			for (int i = 0; i < 5; i++) // Search up to 5 levels up
			{
				var testProjectPath = Path.Combine(currentDir, "DaveSexton.XmlGel.UnitTests", "Maml");
				if (Directory.Exists(testProjectPath))
				{
					return testProjectPath;
				}
				currentDir = Path.GetDirectoryName(currentDir);
				if (currentDir == null) break;
			}
			
			// Last fallback: return current directory
			return Environment.CurrentDirectory;
		}

		public MainWindow()
		{
			ApplicationCommands.New.Subscribe(typeof(MainWindow), _ => New());
			ApplicationCommands.Open.Subscribe(typeof(MainWindow), _ => Open());
			ApplicationCommands.Save.Subscribe(typeof(MainWindow), _ => Save());
			ApplicationCommands.SaveAs.Subscribe(typeof(MainWindow), _ => SaveAs());
			NavigationCommands.FirstPage.Subscribe(typeof(MainWindow), _ => ToggleOutput());

			InitializeComponent();
		}

		private void UpdateTools()
		{
			switch (editor.Document.Kind)
			{
				case MamlDocumentKind.Conceptual:
					break;
			}
		}

		private void UpdateOutput()
		{
			if (!updating && editor.Document != null && IsOutputVisible)
			{
				updating = true;

				try
				{
					editor.Document.Update();
				}
				finally
				{
					updating = false;
				}

				mamlTextBox.Text = editor.Document.Document.ToString();
				structureTextBox.Text = editor.Document.Structure.ToString();
			}
		}

		private void LoadDocument(MamlDocument document)
		{
			updating = true;

			try
			{
				editor.Document = document;
			}
			catch (XmlException ex)
			{
				// TODO: Log error

				MessageBox.Show(this, ex.Message, "Invalid File", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			finally
			{
				updating = false;
			}

			UpdateTools();
			UpdateOutput();
		}

		private void New()
		{
			file = null;

			LoadDocument(MamlDocument.Create(MamlDocumentKind.Conceptual));
		}

		private void Open()
		{
			var dialog = new OpenFileDialog()
			{
				CheckFileExists = true,
				AddExtension = true,
				DefaultExt = MamlDocument.DefaultFileExtension,
				Filter = "MAML Files (*" + MamlDocument.DefaultFileExtension + ";*.maml)|*" + MamlDocument.DefaultFileExtension + ";*.maml|All Files (*.*)|*.*",
				Title = "Open File",
				InitialDirectory = dialogDefaultFolder
			};

			if (dialog.ShowDialog(this) ?? false)
			{
				file = dialog.FileName;

				LoadDocument(MamlDocument.FromFile(file));
			}
		}

		private void Save()
		{
			if (file == null)
			{
				SaveAs();
			}
			else
			{
				SaveCore();
			}
		}

		private void SaveAs()
		{
			var dialog = new SaveFileDialog()
			{
				AddExtension = true,
				DefaultExt = MamlDocument.DefaultFileExtension,
				Filter = "MAML Files (*" + MamlDocument.DefaultFileExtension + ";*.maml)|*" + MamlDocument.DefaultFileExtension + ";*.maml|All Files (*.*)|*.*",
				Title = "Save File",
				InitialDirectory = dialogDefaultFolder
			};

			if (dialog.ShowDialog(this) ?? false)
			{
				file = dialog.FileName;

				SaveCore();
			}
		}

		private void SaveCore()
		{
			editor.Save(file);
		}

		private void ToggleOutput()
		{
			var visibility = IsOutputVisible ? Visibility.Hidden : Visibility.Visible;

			structureTextBox.Visibility = visibility;
			structureSplitter.Visibility = visibility;
			mamlTextBox.Visibility = visibility;
			mamlSplitter.Visibility = visibility;

			if (visibility == Visibility.Hidden)
			{
				Grid.SetColumnSpan(editor, 5);
			}
			else
			{
				editor.ClearValue(Grid.ColumnSpanProperty);

				UpdateOutput();
			}
		}

		private void editor_DocumentContentChanged(object sender, EventArgs e)
		{
			UpdateOutput();
		}
	}
}