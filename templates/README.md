# Templates

This folder contains Visual Studio project and item templates for MAML document creation and development.

## Overview

The templates provide pre-configured Visual Studio templates that enable developers to quickly create MAML projects and documents with proper structure and configuration.

## Template Structure

### Item Templates (`Item/`)
Visual Studio item templates for creating individual MAML documents.

#### MAML Templates (`Item/MAML/`)
Templates for different MAML document types.

##### Conceptual Template (`Item/MAML/Conceptual/`)
**Purpose**: Template for creating Conceptual MAML documents

**Contents:**
- **`Conceptual.aml`**: Template MAML document with proper structure
- **`Conceptual.csproj`**: Visual Studio project configuration
- **`Conceptual.vstemplate`**: Visual Studio template metadata

**Features:**
- Pre-configured MAML document structure
- Proper XML namespace declarations
- Template content placeholders
- Visual Studio integration metadata

## Usage

### In Visual Studio
1. **File → New → Item**
2. **Select MAML Category**
3. **Choose Conceptual Document Template**
4. **Provide document name and location**
5. **Template creates properly structured MAML file**

### Template Benefits
- **Consistent Structure**: All documents follow proper MAML conventions
- **Reduced Errors**: Pre-configured namespaces and structure prevent common mistakes
- **Rapid Development**: Quick document creation with proper boilerplate
- **Standards Compliance**: Templates ensure MAML schema compliance

## Template Development

### Creating New Templates
1. **Create Document Template**: Design the template MAML content
2. **Configure Project Settings**: Set up proper project configuration
3. **Define Template Metadata**: Create .vstemplate file with appropriate settings
4. **Package Template**: Create template package for distribution

### Template Components

#### Document Template (*.aml)
```xml
<?xml version="1.0" encoding="utf-8"?>
<topic xmlns:xlink="http://www.w3.org/1999/xlink" 
       xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
  <!-- Template structure with placeholders -->
</topic>
```

#### Project Configuration (*.csproj)
- References to XMLGel libraries
- Build actions and content settings
- Proper target framework configuration

#### Template Metadata (*.vstemplate)
- Template name and description
- Template type and category
- File associations and project settings

## Integration

### With XMLGel Editor
Templates are designed to work seamlessly with:
- **XMLGel Visual Studio Extension**: Full editing support
- **Schema Validation**: Real-time validation of template content
- **Structure Palette**: Visual editing of template elements
- **IntelliSense**: Schema-driven code completion

### With Visual Studio
- **New Item Dialog**: Templates appear in VS New Item dialog
- **Project Integration**: Templates integrate with VS project system
- **Build Process**: Proper build configuration for MAML processing
- **File Association**: Templates associate with XMLGel editor

## Extensibility

### Adding New Document Types
The template system can be extended to support all MAML document types:

**Supported Types:**
- Conceptual (implemented)
- How-To
- Reference (with/without syntax)
- Glossary
- Error Message
- Troubleshooting
- SDK documentation types
- Walkthrough
- Whitepaper
- XML Reference

### Custom Templates
Organizations can create custom templates:
- **Branded Content**: Company-specific document templates
- **Specialized Structures**: Domain-specific MAML patterns
- **Workflow Integration**: Templates matching specific documentation workflows
- **Style Consistency**: Templates enforcing documentation standards

## File Structure

```
templates/
└── Item/
    └── MAML/
        └── Conceptual/
            ├── Conceptual.aml          # MAML document template
            ├── Conceptual.csproj       # Project configuration  
            └── Conceptual.vstemplate   # VS template metadata
```

## Development Notes

### Template Design Principles
- **Minimal Content**: Templates provide structure, not extensive content
- **Placeholder Text**: Clear placeholders for user customization
- **Schema Compliance**: All templates validate against MAML schemas
- **Best Practices**: Templates demonstrate MAML best practices

### Future Enhancements
- **Complete Template Set**: Templates for all MAML document types
- **Wizard Integration**: Template wizards for guided document creation
- **Content Snippets**: Reusable content snippets for common patterns
- **Localization**: Multi-language template support

These templates provide the foundation for rapid, consistent MAML document development within the Visual Studio environment.