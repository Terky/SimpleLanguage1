﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLang
{
    public class TypeSymbol: Symbol
    {
        public Symbol.ValueType Value { get; set; }
    }
}