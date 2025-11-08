# DaveSexton.XmlGel.Labs

**Experimental Research Platform** - Advanced testing and research environment for exploring new XMLGel features, performance optimizations, and experimental functionality.

## Overview

This project provides an experimental laboratory environment built on the Labs Framework for researching advanced MAML editing scenarios, testing performance optimizations, and developing new features before integration into the main codebase.

## Architecture

### Labs Framework Integration
Built on the DaveSexton Labs Framework for structured experimentation:

**Core Components:**
- **Catalog System**: Organized lab discovery and execution
- **Base Lab Classes**: Structured experiment foundation
- **Activation Strategies**: Flexible lab execution models
- **Priority System**: Ordered execution for dependent experiments

### Lab Categories

#### WPF Labs (`WPF/`)
Advanced WPF UI and layout experimentation:

**ContentControlLab**
- **Purpose**: Advanced content control behavior testing
- **Features**: Custom control development and validation
- **Use Case**: Testing new editor control concepts

**EventMarkupExtensionLab**
- **Purpose**: Advanced XAML markup extension development
- **Features**: Event binding and command integration
- **Use Case**: Simplified event handling in MAML editors

**FlowDocumentLayoutLab**
- **Purpose**: FlowDocument layout engine research
- **Features**: Advanced document layout algorithms
- **Use Case**: Optimizing MAML document rendering and editing
- **Internal Components**: Complex layout measurement and arrangement

**RichTextBoxOleLab**
- **Purpose**: OLE embedding and rich text integration
- **Features**: External object embedding in documents
- **Use Case**: Advanced MAML content integration

#### XML Labs (`XML/`)
XML processing, validation, and schema research:

**MamlSchemaLab**
- **Purpose**: Advanced XML Schema validation research
- **Features**: Schema loading, validation, and error analysis
- **Use Case**: Improving schema validation accuracy and performance
- **Schema Integration**: Direct XSD processing and analysis

**SchemaValidationLab**
- **Purpose**: Real-time validation algorithm optimization
- **Features**: Performance testing and validation accuracy
- **Use Case**: Enhancing editor validation feedback

**XmlBuilderLab**
- **Purpose**: XML generation and manipulation research
- **Features**: Advanced XML construction techniques
- **Use Case**: Optimizing MAML XML output generation

#### Console Labs (`Base Classes`)
Command-line experimentation and automation:

**BaseConsoleLab**
- **Purpose**: Console-based testing infrastructure
- **Features**: Automated testing and batch processing
- **Use Case**: Performance benchmarking and regression testing

**BaseLab**
- **Purpose**: Common lab infrastructure
- **Features**: Shared utilities and common functionality
- **Use Case**: Foundation for all lab experiments

## Lab Catalog System

### Catalog Configuration
The lab catalog uses sophisticated activation strategies:

```csharp
public override LabActivationStrategies Activation => 
    LabActivationStrategies.AllWithExclusions;
```

**Activation Options:**
- **All**: Execute all available labs
- **AllWithExclusions**: Execute all except explicitly excluded
- **Priority-Based**: Execute labs in priority order
- **Anonymous**: Execute labs without specific identification

### Lab Discovery
- **Automatic Discovery**: Scans assembly for lab implementations
- **Type-Based Registration**: Automatic type registration
- **Dependency Resolution**: Manages lab execution dependencies
- **Priority Ordering**: Executes labs in optimal order

## Usage

### Running Labs
1. **Set as StartUp Project**: In Visual Studio
2. **Execute All Labs**: F5 to run lab catalog
3. **Select Specific Labs**: Choose individual experiments
4. **View Results**: Console or WPF output depending on lab type

### Lab Development
1. **Create Lab Class**: Inherit from BaseLab or BaseConsoleLab
2. **Implement Main()**: Define experiment logic
3. **Register in Catalog**: Automatic discovery or explicit registration
4. **Test and Iterate**: Run experiments and refine

### Experimental Workflow

#### Performance Research
1. **Load Test Documents**: Use complex MAML files
2. **Run Performance Labs**: Execute timing and memory tests
3. **Analyze Results**: Compare performance metrics
4. **Optimize Code**: Implement improvements
5. **Validate Changes**: Re-run labs to verify improvements

#### Feature Development
1. **Create Feature Lab**: Build isolated feature test
2. **Prototype Implementation**: Develop feature in lab environment
3. **Test Integration**: Validate integration with core library
4. **Refine Design**: Iterate based on lab results
5. **Graduate to Core**: Move successful features to main codebase

#### Algorithm Research
1. **Implement Algorithm**: Create lab for algorithm testing
2. **Test Edge Cases**: Validate algorithm behavior
3. **Performance Analysis**: Measure algorithm efficiency
4. **Compare Alternatives**: Test multiple approaches
5. **Select Optimal**: Choose best performing solution

## Key Features

### Flexible Experimentation
- **Isolated Environment**: Experiments don't affect main codebase
- **Rapid Prototyping**: Quick feature development and testing
- **Performance Measurement**: Built-in timing and profiling
- **Visual Testing**: WPF labs for UI experimentation

### Research Capabilities
- **Algorithm Development**: Test new editing algorithms
- **Performance Optimization**: Identify and resolve bottlenecks
- **Feature Exploration**: Prototype new functionality
- **Integration Testing**: Validate component interactions

### Development Support
- **Debugging Tools**: Enhanced debugging for experiments
- **Logging Infrastructure**: Comprehensive experiment logging
- **Result Analysis**: Built-in result comparison and analysis
- **Documentation**: Self-documenting experiment results

## Configuration

### Dependencies
- **DaveSexton.Labs**: Core labs framework
- **DaveSexton.XmlGel**: Core library for testing
- **Reactive Extensions (Rx)**: For reactive programming patterns
- **WPF Framework**: For visual experiments

### App Configuration (`app.config`)
- Framework version targeting
- Assembly binding redirects
- Experiment-specific settings

## File Structure

### Core Infrastructure
- **Catalog.cs**: Main lab catalog and discovery
- **BaseLab.cs**: Base class for all experiments
- **BaseConsoleLab.cs**: Console experiment foundation

### WPF Experiments
- **WPF/**: Advanced UI and layout experiments
- ***.xaml**: WPF user interfaces for visual labs
- ***.xaml.cs**: Lab implementation code

### XML Research
- **XML/**: XML processing and schema experiments
- Schema validation and optimization research

### Configuration
- **Properties/**: Assembly configuration
- **app.config**: Application configuration
- **packages.config**: NuGet package management

## Development Guidelines

### Creating New Labs
1. **Inherit from appropriate base**: BaseLab or BaseConsoleLab
2. **Implement Main() method**: Core experiment logic
3. **Add to catalog**: Automatic discovery or manual registration
4. **Document purpose**: Clear experiment documentation
5. **Include cleanup**: Proper resource management

### Best Practices
- **Single Responsibility**: One experiment per lab
- **Clear Naming**: Descriptive lab names and purposes
- **Performance Conscious**: Measure and optimize
- **Exception Handling**: Robust error handling
- **Documentation**: Comprehensive experiment documentation

### Research Ethics
- **Non-Destructive**: Don't modify core library inappropriately
- **Isolated Testing**: Keep experiments contained
- **Reversible Changes**: Ensure changes can be undone
- **Performance Baseline**: Maintain performance benchmarks

This labs environment is crucial for advancing XMLGel capabilities while maintaining stability and quality in the main codebase.