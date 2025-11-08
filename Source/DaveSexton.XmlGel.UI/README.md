# DaveSexton.XmlGel.UI

**Standalone MAML Editor** - A standalone WPF application providing basic MAML document editing capabilities outside of Visual Studio.

## Overview

This is a simple WPF application that demonstrates the core XMLGel editing capabilities. It serves as both a standalone editor for users who don't have Visual Studio and as a reference implementation showing how to integrate the core XMLGel library into custom applications.

## Features

### Basic Document Operations
- **New Document**: Create new MAML documents
- **Open**: Load existing .aml files
- **Save**: Save documents with proper MAML formatting
- **Save As**: Export documents to different locations

### Document Editing
- **Rich Text Editor**: Full MAML editing with visual formatting
- **Structure View**: Toggle between editor and XML structure views
- **Document Validation**: Real-time schema validation feedback
- **Element Insertion**: Basic element insertion capabilities

### Export Capabilities
- **XHTML Export**: Convert MAML to HTML for web publishing
- **Visitor Pattern Demo**: Shows conversion system in action

## Architecture

### Application Structure
- **MainWindow**: Primary application window with editing interface
- **Document Management**: Integration with core XMLGel document system
- **Visitor Integration**: Demonstrates FlowDocument ↔ MAML conversion

### Key Components
- `MainWindow.xaml/.cs` - Main application window
- `App.xaml/.cs` - Application entry point and configuration
- `FlowDocumentToXhtmlVisitor.cs` - XHTML export functionality
- `XhtmlToFlowDocumentVisitor.cs` - XHTML import functionality
- `VisitorTest.cs` - Conversion system testing

### Dependencies
- **DaveSexton.XmlGel**: Core editing library
- **Reactive Extensions (Rx)**: For reactive UI patterns
- **WPF Framework**: UI foundation

## Usage

### Starting the Application
1. Set as startup project in Visual Studio
2. Run with F5 or build and execute directly
3. Default folder is set to user's Documents/MAML Documents

### Basic Workflow
1. **File → New** to create a new MAML document
2. Edit using the rich text editor
3. Use structure palette (hover over margins) to insert elements
4. **File → Save** to save as .aml file
5. Toggle output view to see generated XML

### Testing Different Document Types
The application supports all MAML document types:
- Conceptual documents for general topics
- How-To documents for procedures
- Reference documents for technical details
- And all other MAML formats

## Development Notes

### Purpose
This project serves multiple purposes:
1. **Standalone Editor**: For users without Visual Studio
2. **Integration Example**: Shows how to use the core library
3. **Testing Platform**: Quick testing of core functionality
4. **Demo Application**: Demonstrates XMLGel capabilities

### Limitations
- Basic UI compared to Visual Studio integration
- Limited advanced editing features
- Minimal project management capabilities
- No template system

### Extension Points
The application can be extended with:
- Enhanced UI and editing tools
- Project management features
- Advanced export options
- Plugin architecture for custom document types

## File Structure

- `MainWindow.*` - Primary editor interface
- `App.*` - Application configuration
- `*Visitor.cs` - Document conversion implementations
- `Images/` - Application icons and resources
- `Tests/` - Sample XAML files for testing
- `Properties/` - Assembly info and application settings

## Assembly Information

- **Title**: DaveSexton.XmlGel.UI
- **Company**: Dave Sexton
- **Copyright**: Copyright © 2012 Dave Sexton
- **Framework**: .NET Framework 4.6 with WPF
- **Strong Named**: Yes

## Build and Run

```bash
# Build the application
msbuild DaveSexton.XmlGel.UI.csproj

# Or run from Visual Studio
# Set as StartUp Project → F5
```

The application provides a good starting point for understanding the XMLGel architecture and can be customized for specific MAML editing needs.