# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

XMLGel is an experimental MAML (Microsoft Assistance Markup Language) Editor that provides a visual WPF-based editing experience for creating and editing MAML documentation. The project consists of multiple assemblies targeting .NET Framework 4.6 and uses WPF for the user interface.

## Technology Stack

- **Framework**: .NET Framework 4.8
- **UI Framework**: WPF with XAML
- **Build System**: MSBuild (Visual Studio project system)
- **Testing**: Microsoft Unit Testing Framework (MSTest)
- **Architecture**: Visitor pattern, Document-based editing with XML Schema validation

## Solution Structure

- **Source/DaveSexton.XmlGel**: Core library containing MAML document models, visitors, and editing components
- **Source/DaveSexton.XmlGel.VisualStudio**: Visual Studio extension package
- **Source/DaveSexton.XmlGel.UI**: Basic WPF UI application (legacy)
- **Testing/DaveSexton.XmlGel.UnitTests**: Unit tests for the core library
- **Testing/DaveSexton.XmlGel.UI**: Test WPF application for development
- **Testing/DaveSexton.XmlGel.Labs**: Experimental features and labs
- **External References**: Third-party dependencies (Rxx, Labs frameworks)
- **Artifacts**: Documentation, schemas, and development notes

## Development Commands

### Building
- Build entire solution: `msbuild DaveSexton.XmlGel.sln`
- Build specific project: `msbuild Source\DaveSexton.XmlGel\DaveSexton.XmlGel.csproj`
- Build configurations: Debug (default) or Release

### Testing
- Run unit tests: Use Visual Studio Test Explorer or `mstest` command-line runner
- Test project: `Testing\DaveSexton.XmlGel.UnitTests\DaveSexton.XmlGel.UnitTests.csproj`
- Test data located in: `Testing\DaveSexton.XmlGel.UnitTests\Maml\*`

### Development Setup
- Set `Testing\DaveSexton.XmlGel.UI` as startup project for testing the editor
- The editor provides MAML document editing with schema validation and visual structure palette

## Core Architecture

### Document Model
- **MamlDocument**: Base class for all MAML document types (Conceptual, How-To, Reference, etc.)
- **MamlNode**: Base class for all MAML elements with XML Schema-based validation
- **FlowDocument Integration**: Bidirectional conversion between WPF FlowDocument and MAML XML

### Visitor Pattern Implementation
- **FlowDocumentToXDocumentVisitor**: Converts WPF FlowDocument to MAML XML
- **MamlToFlowDocumentVisitor**: Converts MAML XML to WPF FlowDocument for editing
- **TextElementVisitor**: Base visitor for WPF TextElement hierarchies

### Editor Components
- **MamlTopicEditor**: Main editing control with schema-aware structure palette
- **StructurePalette**: Adorner-based UI for inserting/deleting MAML elements
- **Schema Validation**: Real-time XML Schema validation using embedded XSD files

### MAML Document Types
The system supports multiple MAML document formats:
- Conceptual, How-To, Reference (with/without syntax)
- Glossary, Error Message, Troubleshooting
- SDK documentation types (Architecture, Code Directory, Scenarios, etc.)
- Walkthrough, Whitepaper, XML Reference

## Key Files and Directories

- `Source\DaveSexton.XmlGel\MAML\Documents\`: MAML document type definitions
- `Source\DaveSexton.XmlGel\MAML\Documents\Visitors\`: Document conversion visitors
- `Source\DaveSexton.XmlGel\MAML\Schema\Authoring\`: Embedded XML Schema files
- `Source\DaveSexton.XmlGel\Documents\`: WPF TextElement node implementations
- `Testing\DaveSexton.XmlGel.UI\MainWindow.xaml.cs`: Test application entry point

## Schema and Validation
- XML Schema files embedded as resources from `Artifacts\Schemas\MAML\Authoring\`
- Schema validation provides real-time feedback during editing
- Schema extensibility support for custom MAML elements

## Known Limitations
- Project is experimental and not under active development (per README)
- Complex documents may crash during editing
- Only basic Conceptual MAML format was fully intended to be supported initially