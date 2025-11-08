# DaveSexton.XmlGel.VisualStudio

**Visual Studio Extension Package** - VSIX package that integrates the XMLGel MAML Editor directly into Visual Studio IDE.

## Overview

This Visual Studio extension provides a complete MAML authoring experience within the Visual Studio environment. It includes custom editors, tool windows, project templates, and deep IDE integration for professional MAML document development.

## Features

### Custom Editor Integration
- **File Association**: Automatic handling of .aml files
- **Rich Editor**: Full MAML editing with syntax highlighting and IntelliSense
- **Schema Validation**: Real-time validation with error highlighting
- **Structure Palette**: Visual element insertion and manipulation

### Tool Windows
- **Topic Explorer**: Navigate and manage MAML document collections
- **Structure View**: Hierarchical document outline
- **Properties Window**: Element-specific property editing

### Templates and Wizards
Complete set of MAML document templates:
- **Conceptual**: General documentation topics
- **How-To**: Step-by-step procedures
- **Reference**: API documentation with/without syntax
- **Glossary**: Term definition documents
- **SDK Documentation**: Architecture, scenarios, summaries
- **Specialized**: Error messages, troubleshooting, walkthroughs

### Productivity Features
- **Macro Recording**: Record and replay editing sequences
- **Command Integration**: Custom commands in VS command system
- **Status Bar**: Real-time document status and validation feedback
- **Toolbox Integration**: MAML elements in VS toolbox

## Architecture

### Package Infrastructure
- **MamlPackage**: Main VSPackage implementation
- **Editor Factory**: Custom editor factory for .aml files
- **Command Handling**: Integration with VS command system
- **Service Providers**: VS service integration

### Editor Implementation
- **MamlTopicEditor**: Core editing component
- **MamlTopicEditorPane**: VS editor pane wrapper
- **Persistence**: Document loading/saving with VS integration
- **Extensibility**: Plugin architecture for custom extensions

### Tool Windows
- **TopicExplorerControl**: Document navigation and management
- **TopicExplorerToolWindow**: VS tool window wrapper
- **Docking Support**: Full VS docking and layout integration

## File Structure

### Core Components
- `MamlPackage.cs` - Main VSPackage class
- `MamlTopicEditor*.cs` - Editor implementation files
- `MamlTopicEditorPane*.cs` - Editor pane functionality
- `MamlTopicEditorFactory.cs` - Editor factory

### Integration
- `Guids.cs` - Package and editor GUIDs
- `PkgCmdID.cs` - Command ID definitions
- `*.vsct` - Command table definitions
- `source.extension.vsixmanifest` - Extension manifest

### Templates
- `templates/` - Complete set of MAML document templates
- All major MAML document types included
- Ready-to-use starter content

### Resources
- `Resources/` - Package icons and images
- `*.resx` - Localization resources
- Embedded resources for templates and schemas

## Installation

The extension is packaged as a VSIX file that can be:
1. **Direct Install**: Double-click the .vsix file
2. **VS Gallery**: Publish to Visual Studio Marketplace
3. **Development**: F5 debugging in VS Experimental Hive

## Development Setup

### Building
```bash
msbuild DaveSexton.XmlGel.VisualStudio.csproj
```

### Testing
- Uses Visual Studio Experimental Hive for development
- See `Artifacts\Visual Studio\VS Experimental Hive.txt` for setup notes

### Dependencies
- **Visual Studio SDK**: Required for VS integration
- **DaveSexton.XmlGel**: Core library dependency
- **VS Services**: Editor, command, and tool window services

## Usage

### Opening MAML Files
1. File → New → Item → MAML Document Templates
2. Or open existing .aml files (automatically associated)

### Editing Features
- Structure palette appears on hover over document margins
- Real-time validation with error squiggles
- IntelliSense for MAML elements and attributes
- Integrated help and documentation

### Tool Windows
- View → Other Windows → Topic Explorer
- Dock and arrange as needed within VS layout

## Assembly Information

- **Title**: DaveSexton.XmlGel.VisualStudio
- **Company**: Dave Sexton
- **CLSCompliant**: false (VS interop requirements)
- **ComVisible**: false
- **Strong Named**: Yes