// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Graph.ODataTemplateWriter.TemplateProcessor
{
    using Microsoft.Graph.ODataTemplateWriter.TemplateProcessor.Enums;
    using Vipr.Core.CodeModel;

    public interface ITemplateInfo
    {
        
        string Id { get; }
        string TemplateLanguage { get; set; }
        string TemplateName { get; set; }
        Template TemplateType { get; set; }
        SubProcessor SubprocessorType { get; set; }
        FileNameCasing Casing { get; set; }
        string OutputParentDirectory { get; set; }
        string TemplateBaseName { get; set; }
        string FullPath { get; set; }
        string FileExtension { get; set; }

        bool ShouldIncludeObject(OdcmObject odcmObject);

        string BaseFileName(string containerName = "", string className = "", string propertyName = "", string methodName = "", string propertyType = "");

    }
}
