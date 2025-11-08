# Artifacts

This folder contains development artifacts, documentation, schemas, and research materials for the XMLGel MAML Editor project.

## Overview

The Artifacts folder serves as a central repository for:
- **Project documentation and planning materials**
- **MAML XML Schema definitions and specifications**
- **Research and analysis documents**
- **Development notes and technical documentation**
- **Visual Studio integration documentation**

## Structure

### Schemas (`Schemas/`)
**MAML XML Schema Definitions** - Complete set of XML Schema files defining the MAML specification.

#### MAML Authoring Schemas (`Schemas/MAML/Authoring/`)
Comprehensive collection of XSD files defining MAML document structure:

**Core Schema Files:**
- **`base.xsd`**: Foundation MAML schema with common elements
- **`developer.xsd`**: Developer documentation schema
- **`structure.xsd`**: Document structure definitions
- **`block.xsd`**: Block-level element definitions
- **`inline.xsd`**: Inline element definitions

**Specialized Schema Files:**
- **`blockCommon.xsd`**: Common block elements (paragraphs, sections, etc.)
- **`blockSoftware.xsd`**: Software-specific block elements (code, alerts, etc.)
- **`inlineCommon.xsd`**: Common inline elements (text formatting, etc.)
- **`inlineLinking.xsd`**: Link and reference elements
- **`inlineSoftware.xsd`**: Software-specific inline elements
- **`inlineUi.xsd`**: User interface element definitions

**Document Type Schemas:**
- **`developer.xsd`**: Technical documentation
- **`developerReference.xsd`**: API reference documentation
- **`developerStructure.xsd`**: Structured development documentation
- **`glossary.xsd`**: Glossary and term definitions
- **`hierarchy.xsd`**: Hierarchical document structures

**Supporting Schemas:**
- **`baseConditional.xsd`**: Conditional content support
- **`conditionSet.xsd`**: Condition set definitions
- **`structure*.xsd`**: Various structural definitions (lists, tables, procedures, media)
- **`xlink.xsd`**: XLink specification for linking

**Technical References:**
- **`W3C - XML Schema.txt`**: Reference to W3C XML Schema specification

### Project Planning (`TODO.txt`)
**Development Roadmap** - Major milestones and feature development plan.

**Key Development Areas:**
1. **StructurePalette Enhancement**: Complete schema-based element insertion/deletion
2. **Editor Behavior**: Proper text editing, selection, and clipboard operations
3. **Semantic Editors**: Specialized editing UI for different element types
4. **Visual Studio Integration**: Import/export services, token resolution
5. **SHFB Integration**: Sandcastle Help File Builder compatibility
6. **Visual Studio Polish**: UI consistency with VS standards
7. **Error Reporting**: Comprehensive error reporting and diagnostics
8. **Deployment**: WIX installer and VS package distribution

### Research Documentation

#### Flow Document Analysis (`Flow Document Analysis/`)
**`Bounding Boxes.txt`** - Comprehensive analysis of WPF FlowDocument layout behavior.

**Research Areas:**
- **Structure Bounding Box Calculations**: Mathematical analysis of element positioning
- **Editor Hit Detection**: Understanding of WPF editor interaction behavior
- **Logical Box Algorithms**: Algorithms for calculating element boundaries
- **Insertion Point Analysis**: Text cursor placement and interaction logic

**Key Findings:**
- Detailed insertion point behavior for paragraphs and sections
- Hit detection region calculations based on document structure
- Logical box calculations for nested sections and elements
- Mathematical formulas for element positioning

#### Visual Studio Integration (`Visual Studio/`)
**`VS Experimental Hive.txt`** - Visual Studio experimental hive setup and deployment.

**Configuration:**
- **Extension Path**: Local extension installation location
- **Development Setup**: Experimental hive configuration for VS development
- **Debugging Support**: Extension debugging and testing procedures

### Feature Documentation (`Wikis/`)
**`Features.txt`** - Comprehensive feature specification and marketing points.

**Key Features:**
- **No Dependencies**: Standalone operation without Sandcastle requirement
- **WYSIWYM Editing**: "What You See Is What You Mean" semantic editing
- **Visual Studio Integration**: Seamless VS 2010/2011 integration
- **Standalone Support**: Full functionality without Visual Studio
- **SHFB Compatibility**: Optional Sandcastle Help File Builder integration
- **Complete MAML Support**: Full MAML schema coverage
- **Automatic Fix-up**: Document correction and optimization

## Technical Architecture

### Schema Integration
The MAML schemas provide:
- **Real-time Validation**: Live document validation during editing
- **IntelliSense Support**: Schema-driven autocomplete and suggestions
- **Structure Guidance**: Valid element insertion and hierarchy enforcement
- **Error Detection**: Comprehensive validation error reporting

### Research Application
Research documents inform:
- **Layout Algorithms**: Mathematical basis for visual editor layout
- **Hit Detection**: Precise interaction behavior implementation
- **Performance Optimization**: Understanding of WPF rendering behavior
- **User Experience**: Editor behavior matching user expectations

### Development Planning
Planning documents guide:
- **Feature Prioritization**: Ordered development milestones
- **Integration Strategy**: Visual Studio and third-party tool integration
- **Quality Assurance**: Comprehensive testing and validation approaches
- **User Experience**: Professional-grade editor behavior and features

## Usage

### For Developers
1. **Schema Reference**: Use XSD files for validation implementation
2. **Research Guidance**: Apply research findings to algorithm development
3. **Feature Planning**: Follow TODO roadmap for development priorities
4. **Integration**: Use VS integration documentation for extension development

### For Documentation
1. **Feature Reference**: Use Features.txt for capability documentation
2. **Technical Specifications**: Reference schema files for MAML compliance
3. **Architecture Documentation**: Use research documents for technical depth
4. **Development History**: Track progress using planning documents

## File Organization

```
Artifacts/
├── Flow Document Analysis/     # WPF layout research
│   └── Bounding Boxes.txt     # Mathematical layout analysis
├── Schemas/                   # MAML XML Schema definitions
│   ├── MAML/Authoring/       # Complete MAML XSD collection
│   └── W3C - XML Schema.txt  # Schema specification reference
├── Visual Studio/             # VS integration documentation
│   └── VS Experimental Hive.txt # Development setup
├── Wikis/                    # Feature and capability documentation
│   └── Features.txt          # Comprehensive feature list
└── TODO.txt                  # Development roadmap and milestones
```

This artifacts collection provides the foundational documentation, specifications, and research necessary for developing and maintaining the XMLGel MAML Editor system.