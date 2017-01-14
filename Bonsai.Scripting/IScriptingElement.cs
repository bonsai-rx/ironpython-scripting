﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonsai.Scripting
{
    interface IScriptingElement : INamedElement
    {
        string Description { get; }

        string Script { get; }
    }
}
