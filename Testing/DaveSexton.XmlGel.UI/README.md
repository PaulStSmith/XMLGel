# DaveSexton.XmlGel.UI (Testing)

**Test Application** - Interactive testing environment for manual validation and debugging of XMLGel MAML Editor core functionality.

## Overview

This is the primary testing application for the XMLGel MAML Editor. Unlike the Source version which is a legacy standalone editor, this testing application is specifically designed for development, debugging, and interactive validation of the core editing features.

## Purpose

### Development Testing
- **Interactive Debugging**: Step through editing operations in real-time
- **Feature Validation**: Manually test new features and functionality
- **Visual Debugging**: See document structure and conversion in action
- **Performance Analysis**: Monitor editing performance and responsiveness

### Integration Testing
- **Core Library Integration**: Validate integration with DaveSexton.XmlGel
- **Document Conversion**: Test FlowDocument ↔ MAML XML conversion
- **Schema Validation**: Interactive validation feedback testing
- **Structure Palette**: Test visual editing adorners and UI components

### Demonstration Platform
- **Feature Showcase**: Demonstrate XMLGel capabilities
- **Training Tool**: Teach MAML editing concepts
- **Documentation**: Live examples for documentation

## Features

### Enhanced Testing Interface
Compared to the Source UI version, this testing application includes:

**Advanced Document Operations:**
- **Smart File Loading**: Automatically detects test data location
- **Test Data Integration**: Direct access to unit test MAML files
- **Output Visualization**: Real-time structure and XML output
- **Validation Feedback**: Enhanced error reporting and validation display

**Developer Tools:**
- **Document Structure View**: Toggle between editor and structure views
- **XML Output Panel**: Live MAML XML generation
- **Validation Panel**: Real-time schema validation results
- **Performance Metrics**: Editing operation timing and analysis

### Test Data Access
The application is configured to automatically find and load:
- **Unit Test Data**: Direct access to `Testing\DaveSexton.XmlGel.UnitTests\MAML\` files
- **Sample Documents**: Pre-loaded with test scenarios
- **Template Testing**: All MAML document type templates
- **Complex Examples**: Real-world use cases and edge cases

## Architecture

### Test Integration
- **Automatic Path Resolution**: Finds test data regardless of execution location
- **Fallback Logic**: Gracefully handles missing test files
- **Dynamic Loading**: Load test documents from multiple sources

### Enhanced UI Components
- **Structure Output**: Real-time document structure visualization
- **Toggle Views**: Switch between editing and output modes
- **Error Display**: Enhanced validation error reporting
- **Test Shortcuts**: Quick access to common test scenarios

## Usage

### Getting Started
1. **Set as StartUp Project**: In Visual Studio Solution Explorer
2. **Build and Run**: F5 or Ctrl+F5 to launch
3. **Load Test Document**: File → Open → Browse test data
4. **Toggle Output**: Use toggle button to see XML structure

### Testing Workflow
1. **Open Test Document**: Load from MAML test data directories
2. **Edit Document**: Use structure palette and rich text editing
3. **Validate Changes**: Check real-time validation feedback
4. **View Output**: Toggle to see generated MAML XML
5. **Test Round-Trip**: Save and reload to verify fidelity

### Key Testing Scenarios

#### Document Conversion Testing
1. Load complex test documents (e.g., from UseCases/)
2. Edit using structure palette
3. Verify output matches expected structure
4. Test round-trip conversion fidelity

#### Schema Validation Testing
1. Load documents with known validation issues
2. Observe real-time validation feedback
3. Test error correction and recovery
4. Verify validation accuracy

#### Performance Testing
1. Load large or complex documents
2. Perform intensive editing operations
3. Monitor responsiveness and performance
4. Test memory usage and cleanup

## Configuration

### Test Data Location
The application automatically searches for test data in:
```
1. Current directory: .\Maml\
2. Relative paths: ..\..\..\DaveSexton.XmlGel.UnitTests\Maml\
3. Solution structure: Search up directory tree
4. Fallback: Current working directory
```

### Default Settings
- **Initial Folder**: Automatically detected test data location
- **Document Type**: Conceptual (default for testing)
- **Output Format**: MAML XML with proper formatting
- **Validation**: Enabled with real-time feedback

## File Structure

### Application Core
- **MainWindow.xaml/.cs**: Enhanced test interface with output panels
- **App.xaml/.cs**: Application configuration and startup
- **GetTestDataFolder()**: Smart test data location detection

### Test Resources
- **Images/**: UI icons and testing resources
- **Tests/**: Sample XAML files for UI testing
- **Properties/**: Application configuration and settings

## Development Workflow

### Feature Development
1. **Modify Core Library**: Make changes to DaveSexton.XmlGel
2. **Test Interactively**: Use this application to validate changes
3. **Debug Issues**: Set breakpoints and step through operations
4. **Validate Results**: Check output and behavior

### Issue Reproduction
1. **Load Problematic Document**: Open document showing issues
2. **Reproduce Steps**: Perform operations that cause problems
3. **Analyze Results**: Use output panel to see internal state
4. **Fix and Re-test**: Iterate until issue is resolved

### Performance Analysis
1. **Load Test Documents**: Use large or complex test files
2. **Monitor Performance**: Watch for delays or memory issues
3. **Profile Operations**: Identify performance bottlenecks
4. **Optimize and Re-test**: Validate improvements

## Dependencies

- **DaveSexton.XmlGel**: Core library under test
- **Reactive Extensions (Rx)**: For reactive UI patterns
- **WPF Framework**: Enhanced UI controls and visualization
- **Test Data Files**: Unit test MAML documents

## Assembly Information

- **Title**: DaveSexton.XmlGel.UI
- **Company**: Dave Sexton  
- **Purpose**: Testing and validation platform
- **Framework**: .NET Framework 4.6 with WPF
- **Strong Named**: Yes

This testing application is essential for XMLGel development, providing an interactive environment for validating core functionality and debugging issues in a real-world editing context.