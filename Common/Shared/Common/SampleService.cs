using System.Linq;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System;
using Microsoft.JSInterop;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// The injectable service class used to handle common functionalities all over the application.
    /// </summary>
    public class SampleService
    {
        /// <summary>
        /// Specifies the app is rendering in device or not.
        /// </summary>
        public bool IsDevice { get; set; }
        /// <summary>
        /// Specifies spinner component reference.
        /// </summary>
        public SpinnerComponent Spinner { get; set; }
        /// <summary>
        /// Specifies the current component name.
        /// </summary>
        public string ComponentName { get; set; }
        /// <summary>
        /// Specifies the current sample details.
        /// </summary>
        public Sample SampleInfo { get; set; }
        /// <summary>
        /// Specifies the meta data component reference.
        /// </summary>
        public SampleMetaData MetaData { get; set; }
        /// <summary>
        /// Specifies the very first sample url.
        /// </summary>
        public string FirstSampleUrl { get; set; }
        /// <summary>
        /// Specifies the last sample url.
        /// </summary>
        public string LastSampleUrl { get; set; }
        /// <summary>
        /// Specifies the current sample url.
        /// </summary>
        public string CurrentSampleUrl { get; set; }

        /// <summary>
        /// Specifies the documentation link.
        /// </summary>
        public string DocumentLink { get; set; }

        /// <summary>
        /// Specifies the image url starts path.
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// Specifies the showcase image url starts path.
        /// </summary>
        public string ShowCaseImagePath { get; set; }
        /// <summary>
        /// Specifies the home page loaded or not.
        /// </summary>
        public bool IsHomeLoaded { get; set; }
        /// <summary>
        /// Specifies the demo page loaded or not.
        /// </summary>
        public bool IsDemoLoaded { get; set; }
        /// <summary>
        /// Specifies the demo page js loaded or not.
        /// </summary>
        public bool SampleJSLoaded { get; set; }
        /// <summary>
        /// Specifies the Demos Type whether its WASM or Server.
        /// </summary>
        public string DemoType { get; set; }
        ///// <summary>
        ///// Specifies the Common base script path..
        ///// </summary>
        //public string CommonScriptPath { get; set; }

        ///// <summary>
        ///// Specifies the Common base script path..
        ///// </summary>
        //public string SBScriptPath { get; set; }

        ///// <summary>
        ///// Specifies the diagram component script path.
        ///// </summary>
        //public string DiagramScriptPath { get; set; }
        ///// <summary>
        ///// Specifies the pdfviewer2 script path.
        ///// </summary>
        //public string PdfScriptPath2 { get; set; }
        ///// <summary>
        ///// Specifies the document viewer script path.
        ///// </summary>
        //public string ViewerScriptPath { get; set; }
        ///// <summary>
        ///// Specifies the document editor script path.
        ///// </summary>
        //public string DocScriptPath { get; set; }
        ///// <summary>
        ///// Specifies the spreadsheet script path.
        ///// </summary>
        //public string SpreadsheetScriptPath { get; set; }
        /// <summary>
        /// Specifies the pdfviewer Script loaded or not.
        /// </summary>
        public bool IsPdfScript2Loaded { get; set; }
        /// <summary>
        /// Specifies the document editor script loaded or not.
        /// </summary>
        public bool IsDocScriptLoaded { get; set; }
        /// <summary>
        /// Specifies the spreadsheet script loaded or not.
        /// </summary>
        public bool IsSpreadsheetScriptLoaded { get; set; }
        /// <summary>
        /// Specifies the diagram interop script loaded or not.
        /// </summary>
        public bool IsDiagramScriptLoaded { get; set; }
        /// <summary>
        /// Specifies the Blazor Samples Common Static Web Assets location based on the project.
        /// </summary>
        public string WebAssetsPath { get; set; }
        /// <summary>
        /// Specifies the current sample is PDF Viewer.
        /// </summary>
        public bool IsPdfViewerSample { get; set; }
        /// <summary>
        /// Specifies the current sample is Document Editor/Word Editor.
        /// </summary>
        public bool IsWordEditorSample { get; set; }
        /// <summary>
        /// Specifies the current sample is Spreadsheet.
        /// </summary>
        public bool IsSpreadsheetSample { get; set; }
        /// <summary>
        /// Specifies the current sample is DiagramComponent.
        /// </summary>
        public bool IsDiagramSample { get; set; }

        public static string AssetsPath =
#if WASM
    #if NET8_0
            "_content/Blazor_WASM_Common_NET8/";
    #else
            "_content/Blazor_WASM_Common_NET9/";
    #endif
#else
    #if NET8_0
            "_content/Blazor_Server_Common_NET8/";
    #else
            "_content/Blazor_Server_Common_NET9/";
    #endif
#endif
        public SampleService()
        {
#if WASM
            DemoType = "Blazor Web App WASM Demos";
#else
            DemoType = "Blazor Web App Server Demos";
#endif
            WebAssetsPath = AssetsPath;
#if DEBUG || STAGING
            ImagePath = WebAssetsPath + "images/common/";
            ShowCaseImagePath = WebAssetsPath + "images/showcase/";
            //PdfScriptPath2 = "_content/Syncfusion.Blazor.SfPdfViewer/scripts";
            //DocScriptPath = "_content/Syncfusion.Blazor.WordProcessor/scripts";
            //SpreadsheetScriptPath = "_content/Syncfusion.Blazor.Spreadsheet/scripts";
            //CommonScriptPath = "_content/Syncfusion.Blazor.Core/scripts";
            //DiagramScriptPath = WebAssetsPath + "scripts/diagram/interop.js";
            //SBScriptPath = WebAssetsPath + "scripts/common/highlight.min.js";
            //ViewerScriptPath = WebAssetsPath + "scripts/pdfviewer/interop.js";
#else
            ImagePath = "https://cdn.syncfusion.com/blazor/images/demos/";
            ShowCaseImagePath = "https://cdn.syncfusion.com/blazor/images/showcase/";
            //PdfScriptPath2 = "https://cdn.syncfusion.com/blazor/27.1.48";
            //DocScriptPath = "https://cdn.syncfusion.com/blazor/27.1.48";
            //SpreadsheetScriptPath = "_content/Syncfusion.Blazor.Spreadsheet/scripts";
            //CommonScriptPath = "https://cdn.syncfusion.com/blazor/27.1.48";
            //DiagramScriptPath = WebAssetsPath + "scripts/diagram/interop.min.js";
            //SBScriptPath = WebAssetsPath + "scripts/common/demos.min.js";
            //ViewerScriptPath = WebAssetsPath + "scripts/pdfviewer/interop.min.js";
#endif
        }

        public async void SwicthToDemo(string id, NavigationManager UriHelper, IJSRuntime JsRuntime)
        {
            var Navigation_Url = SampleUtils.IsHomePage(UriHelper) ?  UriHelper.BaseUri + SampleBrowser.SampleList[0].DemoPath : UriHelper.Uri;
#if DEBUG || STAGING
    #if NET8_0
        #if SERVER
            Navigation_Url = id == "server" ? Navigation_Url : Navigation_Url.Replace("blazor-server", "blazor-wasm");
        #endif
        #if WASM
            Navigation_Url =  id == "wasm" ? Navigation_Url : Navigation_Url.Replace("blazor-wasm", "blazor-server");
        #endif
    #else
        #if SERVER
            Navigation_Url = id == "server" ? Navigation_Url : Navigation_Url.Replace("blazor-server", "blazor-wasm");
        #endif
        #if WASM
            Navigation_Url =  id == "wasm" ? Navigation_Url : Navigation_Url.Replace("blazor-wasm", "blazor-server");
        #endif
    #endif
#else
    #if SERVER
        Navigation_Url = id == "server" ? Navigation_Url : Navigation_Url.Replace("blazor-server", "blazor-wasm");
    #endif
    #if WASM
        Navigation_Url = id == "wasm" ? Navigation_Url : Navigation_Url.Replace("blazor-wasm", "blazor-server");
    #endif
#endif
            await JsRuntime.InvokeVoidAsync("open", Navigation_Url, "_blank");
        }

        // Updates the SampleInfo and ComponentName based on current loaded uri.
        internal void Update(NavigationManager urlHelper)
        {
            if (urlHelper.Uri.IndexOf("?theme") != -1)
            {
                var themeName = System.Web.HttpUtility.ParseQueryString(new Uri(urlHelper.Uri).Query).Get("theme");
                var queryString = urlHelper.Uri.Substring(urlHelper.Uri.IndexOf(themeName) + themeName.Length);
                if (queryString != "")
                {
                    string[] themeurl = urlHelper.Uri.Split("?");
                    var url = themeurl[0] + "?theme=" + themeName;
                    urlHelper.NavigateTo(url);
                }
            }
            string updatedUrl = urlHelper.ToBaseRelativePath(urlHelper.Uri);
            if (updatedUrl.Contains("?"))
            {
                updatedUrl = updatedUrl.Substring(0, updatedUrl.IndexOf("?"));
            }
            if (updatedUrl != string.Empty)
            {
                if (updatedUrl.LastIndexOf("/") == updatedUrl.Length - 1)
                {
                    updatedUrl = updatedUrl.Substring(0, updatedUrl.LastIndexOf("/"));
                }
                updatedUrl = updatedUrl.Replace("//", "/");
                string[] splittedUrl = updatedUrl.Split("/");
                if (splittedUrl.Length >= 2)
                {
                    try
                    {
                        string categoryName = splittedUrl[splittedUrl.Length - 2];
                        categoryName = categoryName.Replace("-", string.Empty);
                        SampleList controlInfo;
                        var sampleName = splittedUrl[splittedUrl.Length - 1];
                        if (categoryName == "buttons" && sampleName != "default-functionalities" && sampleName != "keyboard-navigation" || categoryName == "colorpicker" && sampleName == "inline")
                        {
                            controlInfo = SampleBrowser.SampleList.First<SampleList>(control => control.DemoPath.ToLower().Contains(sampleName));
                        }
                        else
                        {
                            controlInfo = SampleBrowser.SampleList.First<SampleList>(control => control.ControllerName.ToLower().Equals(categoryName));
                        }
                        this.ComponentName = controlInfo.Name;
                        var sampleInfo = controlInfo.Samples.Where(control => control.Url.ToLower() == updatedUrl).ToList();
                        if (sampleInfo.Count > 0)
                        {
                            this.SampleInfo = sampleInfo.First();
                        }
                        else
                        {
                            sampleName = sampleName.Replace("-", string.Empty);
                            this.SampleInfo = controlInfo.Samples.Where(control => control.FileName.ToLower() == (sampleName + ".razor")).First();
                        }
                        this.CurrentSampleUrl = this.SampleInfo.Url;
                    }
                    catch
                    {

                    }
                }
                // Navigate a Sample using Component Name
                else if (splittedUrl.Length < 2 && splittedUrl.Length > 0)
                {
                    string categoryName = splittedUrl[splittedUrl.Length - 1];
                    categoryName = categoryName.Replace("-", string.Empty);
                    var controlInfo = SampleBrowser.SampleList.FirstOrDefault<SampleList>(control => control.ControllerName.ToLower().Equals(categoryName));
                    if (controlInfo != null)
                    {
                        if (controlInfo.Samples.Count > 0)
                        {
                            this.SampleInfo = controlInfo.Samples.First();
                        }
                        this.ComponentName = controlInfo.Name;
                        this.CurrentSampleUrl = this.SampleInfo.Url;
                        var newUri = urlHelper.GetUriWithQueryParameters(SampleInfo.Url.ToLower(), new Dictionary<string, object>
                        {
                            ["theme"] = "fluent2"
                        });
                        urlHelper.NavigateTo(newUri);
                    }

                }
            }
        }

        // Updates the documentation link based on current loaded uri.
        internal void UpdateFooter(string currentUrl)
        {
            
            currentUrl = Uri.UnescapeDataString(currentUrl);
            var queryString = System.Web.HttpUtility.ParseQueryString(new Uri(currentUrl).Query);
            // Handled condition to avoid a Culture switching navigation problem.
            if (queryString.Get("redirectUri") != null)
            {
                currentUrl = queryString.Get("redirectUri");
                currentUrl = currentUrl.Split('?')[currentUrl.Split('?').Length - 2];
            }
            else
            {
                currentUrl = queryString.Count != 0 ? currentUrl.Replace(queryString.ToString(), "") : currentUrl;
            }
            currentUrl = ((currentUrl.LastIndexOf('/') != -1)  || (currentUrl.LastIndexOf('?') != -1) || (currentUrl.LastIndexOf('&') != -1)) ? currentUrl.Remove(currentUrl.Length - 1) : currentUrl;
            currentUrl = currentUrl.EndsWith("/") ? currentUrl.TrimEnd('/') : currentUrl;
            var splittedUrl = currentUrl.Split("/");
            var ComponentName = splittedUrl[splittedUrl.Length - 2];
            var ComponentInfo = SampleBrowser.SampleList.First<SampleList>(control => control.ControllerName.ToLower().Equals(ComponentName.Replace("-", string.Empty)));
            if (ComponentInfo.Category.Equals("File Formats"))
            {
                this.DocumentLink = "https://help.syncfusion.com/" + ComponentInfo.Category.ToLower().Replace(" ", "-") + "/" + ComponentName + "/overview";
            }
            else
            {
                var DocLink = string.IsNullOrEmpty(ComponentInfo.CustomDocLink) ? ComponentName + "/blazor" + "/overview" : ComponentInfo.CustomDocLink;
                this.DocumentLink = "https://help.syncfusion.com/document-processing/word/" + DocLink;
            }
        }
        
        // Method for checking current Sample is PDF / Word / Diagram
        public void checkSampleType(string currentUrl)
        {
            if(currentUrl.IndexOf("pdf-") != -1 || currentUrl.IndexOf("powerpoint") != -1)
            {
                IsPdfViewerSample = true;
            } 
            else if (currentUrl.IndexOf("document-") != -1)
            {
                IsWordEditorSample = true;
            } 
            else if (currentUrl.IndexOf("spreadsheet") != -1)
            {
                IsSpreadsheetSample = true;
            }
            else if (currentUrl.IndexOf("diagramcomponent") != -1)
            {
                IsDiagramSample = true;
            }
        }

    }
}
