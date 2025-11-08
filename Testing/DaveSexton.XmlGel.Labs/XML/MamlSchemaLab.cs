using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using DaveSexton.XmlGel.Extensions;
using DaveSexton.XmlGel.Maml;
using DaveSexton.XmlGel.Xml;

namespace DaveSexton.XmlGel.Labs.XML
{
	public sealed class MamlSchemaLab : BaseConsoleLab
	{
		private static string GetSchemasFolder()
		{
			// Try to find the schemas relative to assembly location
			var assemblyLocation = Assembly.GetExecutingAssembly().Location;
			var currentDir = Path.GetDirectoryName(assemblyLocation);
			
			for (int i = 0; i < 5; i++) // Search up to 5 levels up
			{
				var schemaPath = Path.Combine(currentDir, "Artifacts", "Schemas", "MAML", "Authoring");
				if (Directory.Exists(schemaPath))
				{
					return schemaPath;
				}
				currentDir = Path.GetDirectoryName(currentDir);
				if (currentDir == null) break;
			}
			
			// Fallback: return current directory (will likely cause errors, but won't crash)
			return Environment.CurrentDirectory;
		}

		protected override void Main()
		{
			var schemasFolder = GetSchemasFolder();

			XmlSchema schema;
			using (var stream = File.OpenRead(Path.Combine(schemasFolder, "developer.xsd")))
			{
				schema = XmlSchema.Read(stream, InvalidSchema);
			}

			var schemas = new XmlSchemaSet(new NameTable());

			schemas.Add(schema);

			var validator = new XmlFragmentSchemaValidator(
				new Resolver(schemasFolder, InvalidSchema),
				elementSchema => new XElement(elementSchema.GetXName()),
				_ => false,
				_ => null,
				schemas);

			validator.InvalidNode += validator_InvalidNode;
			validator.InvalidAttribute += validator_InvalidAttribute;

			var element = Maml.Maml.GetDefaultDocument(MamlDocumentKind.Conceptual);

			var elementSchemaType = validator.Schemas.GlobalTypes[new XmlQualifiedName("developerConceptualDocumentType", Maml.Maml.Namespace.NamespaceName)];

			validator.EnsureValid(element, _ => (XmlSchemaElement) elementSchemaType);
		}

		private void InvalidSchema(object sender, ValidationEventArgs e)
		{
			if (e.Severity == XmlSeverityType.Error)
			{
				TraceError(e.Exception);
			}
			else
			{
				TraceWarning(e.Message);
			}
		}

		private void validator_InvalidAttribute(XAttribute attribute)
		{
			TraceError("Invalid attribute: " + attribute.Name);
		}

		private void validator_InvalidNode(XNode node)
		{
			var element = node as XElement;

			if (element == null)
			{
				TraceError("Invalid text: " + node);
			}
			else
			{
				TraceError("Invalid element: " + element.Name);
			}
		}

		private sealed class Resolver : XmlResolver
		{
			public override ICredentials Credentials
			{
				set
				{
					throw new NotSupportedException();
				}
			}

			private readonly Uri actualBaseUri;
			private readonly ValidationEventHandler validationEventHandler;

			public Resolver(string basePath, ValidationEventHandler validationEventHandler)
			{
				this.actualBaseUri = new Uri(basePath, UriKind.Absolute);
				this.validationEventHandler = validationEventHandler;
			}

			public override Uri ResolveUri(Uri baseUri, string relativeUri)
			{
				return new Uri(actualBaseUri, relativeUri);
			}

			public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
			{
				using (var stream = File.OpenRead(absoluteUri.LocalPath))
				{
					return XmlSchema.Read(stream, validationEventHandler);
				}
			}
		}
	}
}