# Source

This folder contains the core source code projects for the XMLGel MAML Editor solution.

## Projects

### DaveSexton.XmlGel
**Core Library** - The main library containing all MAML document models, editing components, and XML processing functionality.

**Key Components:**
- **Document Models**: WPF TextElement node implementations for rich text editing
- **MAML Engine**: Complete MAML document type support with XML Schema validation
- **Visitor Pattern**: Bidirectional conversion between WPF FlowDocument and MAML XML
- **Schema Validation**: Real-time XML Schema validation using embedded XSD files
- **Editor Controls**: Custom WPF controls for MAML editing with structure palette

**Core Namespaces:**
- `Documents/` - WPF TextElement node implementations and editing components
- `MAML/` - Complete MAML document type system with schema-driven validation
- `MAML/Documents/` - Specific MAML document types (Conceptual, How-To, Reference, etc.)
- `MAML/Documents/Adorners/` - Visual editing adorners and structure palette UI
- `MAML/Documents/Visitors/` - Document conversion visitors for all MAML types
- `Extensions/` - Extension methods for WPF, XML, and schema handling
- `XML/` - Low-level XML processing and schema validation infrastructure

### DaveSexton.XmlGel.VisualStudio
**Visual Studio Extension** - VSIX package providing MAML editing capabilities within Visual Studio.

**Key Components:**
- **Editor Integration**: Custom editor factory and editor panes for .aml files
- **Tool Windows**: Topic Explorer and structure navigation tools
- **Templates**: Item templates for various MAML document types
- **Package Services**: VS package infrastructure and command handling

**Features:**
- Integrated MAML topic editor with Visual Studio
- Topic explorer tool window
- MAML document templates and wizards
- Macro recording and playback for repetitive editing tasks

### DaveSexton.XmlGel.UI
**Standalone Editor** - Legacy WPF application providing basic MAML editing functionality.

**Key Components:**
- Simple WPF application for standalone MAML editing
- Basic document management (New, Open, Save, Save As)
- Document structure visualization and editing
- XHTML export/import visitors for web publishing

**Note**: This is the legacy standalone editor. The main development focus is on the Visual Studio integration project.

## Architecture

The solution follows a layered architecture:

1. **Core Library (XmlGel)**: Provides all fundamental MAML editing, validation, and conversion functionality
2. **Visual Studio Extension**: Integrates the core functionality into Visual Studio IDE
3. **Standalone UI**: Simple WPF application using the core library

## Dependencies

- **.NET Framework 4.6+**
- **WPF** for user interface components
- **XML Schema** validation for MAML documents
- **External References**: Rxx (Reactive Extensions), Labs Framework

## Build Requirements

Build the projects in this order:
1. `DaveSexton.XmlGel` (core library)
2. `DaveSexton.XmlGel.UI` (depends on core)
3. `DaveSexton.XmlGel.VisualStudio` (depends on core)