# Testing

This folder contains all testing and experimental projects for the XMLGel MAML Editor solution.

## Projects

### DaveSexton.XmlGel.UnitTests
**Comprehensive Unit Test Suite** - MSTest-based testing framework with extensive MAML document validation and round-trip testing.

**Test Coverage:**
- **MAML Document Round-Trip Testing**: Ensures lossless conversion between formats
- **Schema Validation Testing**: Validates XML Schema compliance and error detection
- **Document Layout Testing**: Tests MamlPartLayout functionality across different structures
- **Run Normalization Testing**: Validates text run merging and optimization
- **Auto-Fix Testing**: Tests automatic document correction capabilities

**Test Data:**
- **MAMLGuide/**: Comprehensive MAML guide documentation samples
- **SampleTopics/**: Real-world MAML document examples
- **UseCases/**: Complex use case scenarios from actual projects
- **Templates/**: All MAML document type templates
- **AutoFix/**: Documents for testing automatic correction features

### DaveSexton.XmlGel.UI
**Test Application** - Interactive testing environment for XMLGel core functionality.

**Purpose:**
- Manual testing of editing features
- Interactive debugging of document conversion
- Demonstration of core library capabilities
- Development testing platform

### DaveSexton.XmlGel.Labs
**Experimental Features** - Labs framework for testing experimental functionality and research.

**Lab Categories:**
- **WPF Labs**: Advanced WPF editing and layout experiments
- **XML Labs**: Schema validation and XML processing research
- **Console Labs**: Command-line testing and automation

## Test Architecture

### Unit Testing Framework
The unit tests use a sophisticated T4 template-based generation system:

1. **T4 Templates** (`*.tt`): Generate test methods from MAML file collections
2. **AmlUnitTestGenerator.ttinclude**: Core template logic for test generation
3. **Generated Tests** (`*.cs`): Auto-generated test classes with proper file paths
4. **Test Data Files** (`*.aml`): Actual MAML documents used for testing

### Test Categories

#### Round-Trip Testing
Tests that ensure perfect fidelity when converting:
```
MAML XML → FlowDocument → MAML XML
```

#### Validation Testing
- Schema validation accuracy
- Error detection and reporting
- Expected particle validation
- Invalid document handling

#### Layout Testing
- Document structure layout algorithms
- Paragraph and section organization
- Nested element handling
- Edge case scenarios

## Key Features

### Automated Test Generation
The T4 template system automatically generates test methods for all MAML files:
- Scans directories for `.aml` files
- Creates test methods with proper naming
- Handles expected results and configuration files
- Maintains relative file paths for portability

### Comprehensive Coverage
- **150+ Generated Test Methods**: Covering all MAML document types
- **Real-World Examples**: Based on actual documentation projects
- **Edge Cases**: Complex nested structures and corner cases
- **Error Scenarios**: Invalid documents and recovery testing

### Labs Framework Integration
The Labs project provides:
- **Interactive Experimentation**: Live testing of new features
- **Performance Analysis**: Benchmarking and optimization testing
- **Research Platform**: Investigation of advanced scenarios

## Running Tests

### Unit Tests
```bash
# Run all tests
mstest /testcontainer:DaveSexton.XmlGel.UnitTests.dll

# Or use Visual Studio Test Explorer
Test → Windows → Test Explorer → Run All
```

### Interactive Testing
1. Set `DaveSexton.XmlGel.UI` as startup project
2. Press F5 to launch test application
3. Use File menu to open test documents from `MAML/` folders

### Labs Experiments
1. Set `DaveSexton.XmlGel.Labs` as startup project
2. Run to see available lab experiments
3. Select specific labs to execute

## Test Data Organization

### Structure
```
MAML/
├── AutoFix/           # Document correction testing
├── MAMLGuide/         # Complete MAML guide samples
├── SampleTopics/      # Realistic documentation examples
├── Templates/         # All document type templates
├── UseCases/          # Complex real-world scenarios
└── templates/         # Template testing files
```

### File Types
- **`.aml`**: MAML document files
- **`-Expected.aml`**: Expected output for comparison tests
- **`.config`**: Test configuration (error counts, special settings)
- **`.tt`**: T4 templates for test generation

## Development Workflow

1. **Add Test Data**: Place new `.aml` files in appropriate directories
2. **Regenerate Tests**: T4 templates automatically create test methods
3. **Run Validation**: Execute tests to verify functionality
4. **Debug Issues**: Use test application for interactive debugging

## Dependencies

- **MSTest Framework**: Microsoft unit testing infrastructure
- **Labs Framework**: Experimental testing platform
- **T4 Templates**: Code generation for test methods
- **Core XMLGel Library**: Testing target