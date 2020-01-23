﻿// Copyright (C) Microsoft. All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using System.IO;

namespace Microsoft.DevSkim.CLI.Writers
{
    public abstract class Writer
    {
        public TextWriter TextWriter { get; set; }
        public abstract void WriteIssue(IssueRecord issue);
        public abstract void FlushAndClose();
    }
}
