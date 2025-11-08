# DaveSexton.XmlGel.UnitTests

**Comprehensive Unit Test Suite** - Automated testing framework ensuring XMLGel MAML Editor quality and reliability through extensive document validation and round-trip testing.

## Overview

This test project provides comprehensive validation of the XMLGel MAML editing system using Microsoft's MSTest framework. It features automated test generation from real MAML documents and ensures perfect fidelity in document conversion and editing operations.

## Test Architecture

### T4 Template-Based Test Generation
The test suite uses an innovative T4 template system to automatically generate test methods:

**Core Components:**
- **`AmlUnitTestGenerator.ttinclude`**: Master template for generating test classes
- **`*.tt` Files**: Individual test class templates (AutoFix.tt, MamlGuide.tt, etc.)
- **Generated `*.cs` Files**: Complete test classes with proper method signatures

**Generation Process:**
1. Templates scan directories for `.aml` files
2. Automatically create test methods with proper naming conventions
3. Handle expected result files (`*-Expected.aml`)
4. Process configuration files (`*.config`) for special test parameters
5. Generate relative file paths for cross-platform compatibility

### Test Categories

#### AutoFix Tests (`AutoFix/`)
Tests for automatic document correction functionality:
- **ConceptualDocument**: Basic conceptual document correction
- **MoveParaIntoMissingContent**: Content organization fixes
- **SectionTitle**: Section title correction and validation
- **SectionTitleAndMoveParaIntoMissingContent**: Combined corrections
- **Unfixable-UnexpectedProcedure**: Error handling for uncorrectable issues

#### MAML Guide Tests (`MAMLGuide/`)
Comprehensive testing using complete MAML documentation:
- **Root Level**: Core documentation files (Glossary, IntelliSense, KnownIssues, etc.)
- **BlockElements/**: Testing all block-level MAML elements
- **CommonInline/**: Validation of inline elements and formatting
- **FileTypes/**: Different MAML file type handling
- **LinkElements/**: Link processing and validation
- **MediaElements/**: Media content handling
- **MiscElements/**: Miscellaneous and specialized elements
- **VersionHistory/**: Version tracking and change documentation

#### Sample Topics Tests (`SampleTopics/`)
Real-world documentation examples:
- **AIP (Application Integration Platform)**: Complete documentation set
- **How-To Guides**: Bibliography, linking, media, snippets, tokens
- **Fruits and Veggies Glossary**: Glossary document validation

#### Use Cases Tests (`UseCases/`)
Complex scenarios from actual projects:
- **Microsoft Media Platform**: Complete framework documentation
- **SlimTune**: Profiler documentation with advanced features
- **Diagnostics**: Complex nested document structures

#### Templates Tests (`Templates/`)
Validation of all MAML document type templates:
- All standard MAML document types
- Proper template structure and validation
- Default content verification

### Document Layout Tests (`Documents/`)
Advanced layout and structure testing:
- **MamlPartLayoutTests**: Document part positioning and layout
- **RunNormalizationTests**: Text run optimization and merging
- Various structure scenarios (basic, jagged, nested, structureless)

### XML Schema Tests (`XML/`)
Low-level XML Schema validation:
- **SchemaExpectedParticlesTests**: Schema particle validation
- **Invalid/Valid document testing**: Error detection accuracy
- **Schema compliance verification**: Complete XSD validation

## Test Data Structure

### Organization
```
MAML/
├── AutoFix/                    # Document correction tests
│   ├── *.aml                   # Test documents
│   ├── *-Expected.aml          # Expected results
│   └── *.config                # Test configuration
├── MAMLGuide/                  # Comprehensive guide samples
│   ├── BlockElements/          # Block element tests
│   ├── CommonInline/           # Inline element tests
│   ├── FileTypes/              # File type tests
│   ├── LinkElements/           # Link tests
│   ├── MediaElements/          # Media tests
│   ├── MiscElements/           # Miscellaneous tests
│   └── VersionHistory/         # Version tests
├── SampleTopics/               # Real-world examples
├── Templates/                  # Template validation
├── UseCases/                   # Complex scenarios
│   ├── mmp-player-framework/   # Media platform docs
│   └── slimtune/              # Profiler docs
└── templates/                  # Additional templates
```

### File Types
- **`.aml`**: MAML document files for testing
- **`-Expected.aml`**: Expected output for comparison tests
- **`.config`**: XML configuration files specifying:
  - `expectedInvalidNodeCount`: Expected validation errors
  - `expectedInvalidAttributeCount`: Expected attribute errors
- **`.tt`**: T4 templates for test generation
- **`.ttinclude`**: Shared T4 template logic

## Test Execution

### Round-Trip Testing
Core test pattern that ensures perfect document fidelity:

```csharp
[TestMethod]
public void TestName()
{
    TestRoundTrip(
        topic: File.ReadAllText(@"Maml\Category\Document.aml"),
        expected: File.ReadAllText(@"Maml\Category\Document-Expected.aml"));
}
```

### Validation Testing
Tests with expected validation errors:

```csharp
[TestMethod]
public void TestWithErrors()
{
    TestRoundTrip(
        topic: File.ReadAllText(@"Maml\Document.aml"),
        expectedInvalidNodeCount: 5,
        expectedInvalidAttributeCount: 2);
}
```

### Base Test Infrastructure (`BaseTests.cs`)
- **TestRoundTrip()**: Core testing method
- **Document conversion validation**
- **Schema validation verification**
- **Error counting and reporting**
- **Performance measurement**

## Running Tests

### Visual Studio
1. **Test Explorer**: View → Test Windows → Test Explorer
2. **Run All**: Execute complete test suite
3. **Filter**: Run specific test categories
4. **Debug**: Step through failing tests

### Command Line
```bash
# Run all tests
mstest /testcontainer:DaveSexton.XmlGel.UnitTests.dll

# Run specific test category
mstest /test:AutoFixTests /testcontainer:DaveSexton.XmlGel.UnitTests.dll
```

### Continuous Integration
Tests are designed for automated CI/CD pipelines:
- **Self-contained**: All test data included
- **Deterministic**: Consistent results across environments
- **Fast execution**: Optimized for rapid feedback

## Configuration

### Assembly Setup (`Global.cs`)
- **Contract failure handling**: Code Contracts integration
- **Test environment setup**: Global test configuration
- **Error handling**: Graceful test failure management

### Dependencies
- **MSTest Framework**: Microsoft unit testing infrastructure
- **DaveSexton.XmlGel**: Core library under test
- **DaveSexton.XmlGel.Labs**: Shared testing utilities

## Adding New Tests

### Manual Addition
1. Add `.aml` file to appropriate directory
2. Optionally add `-Expected.aml` for comparison
3. Add `.config` file if expecting validation errors
4. Regenerate tests by saving T4 templates

### Expected Result Creation
1. Run test with new document
2. Verify the generated output
3. Save verified output as `-Expected.aml`
4. Re-run test to confirm round-trip fidelity

### Configuration Files
Create `.config` files for documents with expected errors:
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <expectedInvalidNodeCount>5</expectedInvalidNodeCount>
  <expectedInvalidAttributeCount>2</expectedInvalidAttributeCount>
</configuration>
```

This comprehensive test suite ensures that XMLGel maintains perfect document fidelity and robust error handling across all supported MAML document types and scenarios.