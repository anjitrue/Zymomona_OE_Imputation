﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImputeMissing_OverExpression_Values
{
    public static class Global
    {
        [ThreadStatic] public static readonly Random Random = new Random(69);
    }
}
