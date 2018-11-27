﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#if RAZOR_EXTENSION_DEVELOPER_MODE
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace Microsoft.VisualStudio.LanguageServices.Razor
{
    internal interface IRazorEngineDocumentGenerator
    {
        Task<RazorEngineDocument> GenerateDocumentAsync(Workspace workspace, Project project, string filePath, string text, CancellationToken cancellationToken = default(CancellationToken));
    }
}
#endif