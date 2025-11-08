using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaveSexton.XmlGel.UnitTests.Maml
{
	[TestClass]
	public class AutoFixTests : BaseTests
	{
		[TestMethod]
		public void AutoFix_ConceptualDocument()
		{
			TestRoundTrip(
				topic: File.ReadAllText(@"Maml\AutoFix\ConceptualDocument.aml"), 
				expected: File.ReadAllText(@"Maml\AutoFix\ConceptualDocument-Expected.aml"));
		}

		[TestMethod]
		public void AutoFix_MoveParaIntoMissingContent()
		{
			TestRoundTrip(
				topic: File.ReadAllText(@"Maml\AutoFix\MoveParaIntoMissingContent.aml"), 
				expected: File.ReadAllText(@"Maml\AutoFix\MoveParaIntoMissingContent-Expected.aml"));
		}

		[TestMethod]
		public void AutoFix_SectionTitle()
		{
			TestRoundTrip(
				topic: File.ReadAllText(@"Maml\AutoFix\SectionTitle.aml"), 
				expected: File.ReadAllText(@"Maml\AutoFix\SectionTitle-Expected.aml"));
		}

		[TestMethod]
		public void AutoFix_SectionTitleAndMoveParaIntoMissingContent()
		{
			TestRoundTrip(
				topic: File.ReadAllText(@"Maml\AutoFix\SectionTitleAndMoveParaIntoMissingContent.aml"), 
				expected: File.ReadAllText(@"Maml\AutoFix\SectionTitleAndMoveParaIntoMissingContent-Expected.aml"));
		}

		[TestMethod]
		public void AutoFix_Unfixable_UnexpectedProcedure()
		{
			TestRoundTrip(
				topic: File.ReadAllText(@"Maml\AutoFix\Unfixable-UnexpectedProcedure.aml"),
				expectedInvalidNodeCount: 1);
		}
	}
}