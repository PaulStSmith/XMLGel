# DaveSexton.XmlGel

**Core Library** - The heart of the XMLGel MAML Editor providing comprehensive MAML document editing, validation, and conversion capabilities.

## Overview

This library implements a complete MAML (Microsoft Assistance Markup Language) editing system built on WPF's FlowDocument architecture. It provides bidirectional conversion between rich WPF editing controls and MAML XML documents with real-time schema validation.

## Key Features

- **Rich Text Editing**: WPF TextElement-based editing with full MAML element support
- **Schema Validation**: Real-time XML Schema validation with embedded XSD files
- **Document Types**: Support for all MAML document types (Conceptual, How-To, Reference, etc.)
- **Visual Editing**: Structure palette adorners for visual element insertion/deletion
- **Bidirectional Conversion**: Seamless conversion between FlowDocument and MAML XML

## Architecture

### Document System (`Documents/`)
WPF TextElement node implementations that map to MAML elements:

- **Node Types**: BlockNode, InlineNode, SectionNode implementations
- **Specialized Nodes**: CollapsibleSection, HeaderedSection, Options, etc.
- **Container Management**: Proper parent-child relationships and validation
- **Command Support**: Custom commands for document manipulation

### MAML Engine (`MAML/`)

#### Document Types (`MAML/Documents/`)
Complete implementation of all MAML document formats:
- **ConceptualDocument**: General documentation topics
- **HowToDocument**: Step-by-step procedures  
- **ReferenceDocument**: API and technical reference
- **GlossaryDocument**: Term definitions
- **SampleDocument**: Code samples and examples
- **SDK Documents**: Architecture, scenarios, summaries
- **Specialized**: Error messages, troubleshooting, walkthroughs

#### Visual Editing (`MAML/Documents/Adorners/`)
Advanced visual editing system:
- **StructurePalette**: Context-sensitive element insertion UI
- **GhostLabelsAdorner**: Visual element labels and guides
- **MouseAdorner**: Interactive element selection and manipulation
- **StructureTab**: Hierarchical document structure visualization

#### Conversion System (`MAML/Documents/Visitors/`)
Visitor pattern implementation for document conversion:
- **MamlToFlowDocumentVisitor**: MAML XML → WPF FlowDocument
- **FlowDocumentToMamlVisitor**: WPF FlowDocument → MAML XML
- **Document-Specific Visitors**: Specialized converters for each document type
- **Bidirectional Fidelity**: Lossless round-trip conversion

### Schema Validation (`XML/`)
Robust XML Schema validation infrastructure:
- **XmlFragmentSchemaValidator**: Real-time document validation
- **Schema Integration**: Embedded XSD files with local resolution
- **Error Reporting**: Detailed validation error messages
- **Expected Particles**: Advanced schema-aware editing assistance

### Extension Methods (`Extensions/`)
Utility extensions for enhanced functionality:
- **TextElementExtensions**: WPF TextElement manipulation
- **XmlSchemaExtensions**: Advanced schema querying and validation
- **DrawingContextExtensions**: Custom rendering support
- **TextPointerExtensions**: Advanced text navigation

## Usage

### Basic Document Creation
```csharp
var document = new ConceptualDocument();
document.Title = "My Topic";
document.Introduction = new MamlIntroduction { /* content */ };
```

### Converting to FlowDocument
```csharp
var visitor = new ConceptualDocumentToFlowDocumentVisitor();
var flowDoc = visitor.Visit(mamlDocument);
```

### Schema Validation
```csharp
var validator = new XmlFragmentSchemaValidator(schemas);
var errors = validator.Validate(xmlDocument);
```

### Visual Editing
```csharp
var editor = new MamlTopicEditor();
editor.Document = mamlDocument;
// Structure palette and adorners automatically enabled
```

## Dependencies

- **.NET Framework 4.6+**
- **PresentationCore/Framework** (WPF)
- **System.Xml.Linq** for XML processing
- **System.Xaml** for XAML support

## Assembly Information

- **Title**: DaveSexton.XmlGel
- **Company**: Dave Sexton
- **Copyright**: Copyright © 2012 Dave Sexton
- **Strong Named**: Yes (Key.snk)
- **Internal Visibility**: Exposed to UnitTests and Labs assemblies