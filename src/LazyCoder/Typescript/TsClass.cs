using System;
using System.Collections.Generic;

namespace LazyCoder.Typescript
{
    public class TsClass : ITsDeclaration
    {
        public TsName Name { get; set; }
        public TsExportKind ExportKind { get; set; }
        public IEnumerable<TsName> Base { get; set; } = Array.Empty<TsName>();
    }
}
