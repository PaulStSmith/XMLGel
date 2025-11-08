using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaveSexton.XmlGel.UnitTests.Maml
{
	[TestClass]
	public class TemplatesTests : BaseTests
	{
		[TestMethod]
		public void Maml_Templates_Conceptual()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Conceptual.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Error_Message()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Error Message.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Glossary()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Glossary.aml"));
		}

		[TestMethod]
		public void Maml_Templates_How_To()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\How To.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Orientation()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Orientation.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Reference_With_Syntax()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Reference With Syntax.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Reference_Without_Syntax()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Reference Without Syntax.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Reference()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Reference.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Sample()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Sample.aml"));
		}

		[TestMethod]
		public void Maml_Templates_SDK_Technology_Architecture()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\SDK Technology Architecture.aml"));
		}

		[TestMethod]
		public void Maml_Templates_SDK_Technology_Code_Directory()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\SDK Technology Code Directory.aml"));
		}

		[TestMethod]
		public void Maml_Templates_SDK_Technology_Orientation()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\SDK Technology Orientation.aml"));
		}

		[TestMethod]
		public void Maml_Templates_SDK_Technology_Scenarios()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\SDK Technology Scenarios.aml"));
		}

		[TestMethod]
		public void Maml_Templates_SDK_Technology_Summary()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\SDK Technology Summary.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Troubleshooting()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Troubleshooting.aml"));
		}

		[TestMethod]
		public void Maml_Templates_User_Interface_Reference()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\User Interface Reference.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Walkthrough()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Walkthrough.aml"));
		}

		[TestMethod]
		public void Maml_Templates_Whitepaper()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\Whitepaper.aml"));
		}

		[TestMethod]
		public void Maml_Templates_XML_Reference()
		{
			TestRoundTrip(topic: File.ReadAllText(@"Maml\Templates\XML Reference.aml"));
		}

	}
}
