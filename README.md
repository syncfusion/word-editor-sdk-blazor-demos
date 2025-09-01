# Syncfusion® Blazor Docx Editor SDK Demos
This repository contains the demos of Syncfusion® Blazor [**Docx Editor**](https://document.syncfusion.com/demos/docx-editor/blazor-server/document-editor/default-functionalities) Component samples.
The following topics can help you to use the Syncfusion Blazor Docx Editor and run this application in your local. 
* [Requirements to run the demo](#requirements-to-run-the-demo)
* [How to run the demo](#how-to-run-the-demo)
* [Docx Editor Components Catalog](#Word-viewer-components-catalog)
* [License](#license)
* [Support and feedback](#support-and-feedback)
## Requirements to run the demo
* [System requirements](https://help.syncfusion.com/document-processing/system-requirements)
* [NET 8 WebAssembly Workload / NET 9 WebAssembly Workload](https://learn.microsoft.com/en-us/aspnet/core/blazor/webassembly-build-tools-and-aot?view=aspnetcore-8.0#net-webassembly-build-tools) (For [Docx Editor Component](https://help.syncfusion.com/document-processing/word/word-processor/blazor/getting-started/web-app))
* Nodejs Version : [10.24.* or above](https://nodejs.org/download/release/v8.1.0/)
## How to run the demo
Clone the repository. This repository contains Blazor Server demos and Blazor WASM demos project and solution files for .NET 8 and .NET 9. This repository has Common, Blazor Server Demos, and Blazor WASM Demos folders.
* `Blazor-Server-Demos` folder has solution and project files to run Blazor server demos.
* `Blazor-WASM-Demos` folder has solution and project files to run Blazor WebAssembly demos.
* The Common folder contains all the common files (i.e., samples, static web assets, resources) which are applicable for both Blazor Server demos and Blazor WASM demos.
### Run the demo using .NET CLI
* Open the command prompt from the demo's directory.
* Run the demo using the following command.
   
   To run .NET 8 Blazor Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET8.csproj`
   To run .NET 9 Blazor Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET9.csproj`
   To run .NET 8 Blazor WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos_NET8.csproj`
   To run .NET 9 Blazor WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos_NET9.csproj`
### Run the demo using Visual Studio
* Open the solution file using Visual Studio.
* Press `Ctrl + F5` to run the demo.
### Run the demo using Visual Studio code
* Open the Visual Studio code from the demos directory where the project file is present.
    > Ensure the [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) extension is installed in your Visual Studio code before running the Blazor demos.
* Press `Ctrl + F5` to run the demo.
## Docx Editor Components Catalog
This repository focuses on Docx Editor components with comprehensive examples showcasing various features and functionalities.
### Docx Editor Component
The **Syncfusion® Blazor Docx Editor** component allows you to view, review, and print Word files in web applications. It provides a rich set of features for working with Word documents.
**Key Features:**
- View Word documents with zoom, pan, and navigate
- Built-in toolbar with essential features
- Annotation support (Text markup, Shape, Sticky notes, etc.)
- Form filling and form designer
- Digital signature support
- Customizable toolbar
- Print and download functionality
- Responsive design
**Available Samples:**
- [Default Functionalities](https://document.syncfusion.com/demos/docx-editor/blazor-server/document-editor/default-functionalities)
- [Custom Toolbar](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/custom-toolbar) 
- [Annotations Toolbar](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/annotations-toolbar)
- [Form Designer](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/form-designer)
- [Form Filling](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/form-filling)
- [Handwritten Signature](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/handwritten-signature)
- [Digital Signature](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/invisible-digital-signature)
- [Document List](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/document-list)
- [Read Only](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/read-only)
- [Redaction](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/redaction)
- [Multi-Format Viewer](https://document.syncfusion.com/demos/Word-viewer/blazor-server/Word-viewer/multi-format-viewer)
**Documentation:** [Docx Editor Documentation](https://help.syncfusion.com/document-processing/Word/Word-viewer/blazor/getting-started/web-app)
---

## Getting Started
### Docx Editor
To get started with the Docx Editor component:
1. Install the Syncfusion.Blazor.DocumentEditor NuGet package
2. Configure the Document Editor in your application
3. Add the Document Editor component to your Blazor page
```csharp
@page "/document-editor"
@using Syncfusion.Blazor.DocumentEditor;
<SfDocumentEditorContainer @ref="@containerRef" 
              RestrictEditing="@ReadOnly"
              ShowPropertiesPane="@ShowProperties"
              Height="100%" Width="100%">
</SfDocumentEditorContainer>
```
## License
Syncfusion Blazor Components is available under the Syncfusion Essential Studio program, and can be licensed either under the Syncfusion Community License Program or the Syncfusion commercial license.
To be qualified for the Syncfusion Community License Program, you must have gross revenue of less than one (1) million U.S. dollars (USD 1,000,000.00) per year and have less than five (5) developers in your organization, and agree to be bound by Syncfusion's terms and conditions.
Customers who do not qualify for the community license can contact sales@syncfusion.com for commercial licensing options.
You may not use this product without first purchasing a Community License or a Commercial License, as well as agreeing to and complying with Syncfusion's license terms and conditions.
The Syncfusion license that contains the terms and conditions can be found at
[https://www.syncfusion.com/content/downloads/syncfusion_license.Word](https://www.syncfusion.com/content/downloads/syncfusion_license.Word)
## Support and feedback
* For any other queries, reach the [Syncfusion support team](https://support.syncfusion.com/) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=github&utm_medium=listing&utm_campaign=blazor-samples).
* To renew the subscription, click [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing&utm_campaign=blazor-Wordviewer-samples) or contact our sales team at <salessupport@syncfusion.com>.
* Don't see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/blazor-components).
## See also
* [Blazor Docx Editor Documentation](https://help.syncfusion.com/document-processing/word/word-processor/blazor/getting-started)
* [Blazor Docx Editor Live Demos](https://document.syncfusion.com/demos/docx-editor/blazor-server/document-editor/default-functionalities)
* [Blazor Smart Docx Editor Live Demos](https://document.syncfusion.com/demos/docx-editor/blazor-server/ai-documenteditor/smart-ai-assist)
* [Syncfusion Blazor Components](https://www.syncfusion.com/blazor-components)
* [Blazor Documentation](https://blazor.syncfusion.com/documentation/introduction)
* [Blazor Smart/AI Samples](https://github.com/syncfusion/smart-ai-samples)