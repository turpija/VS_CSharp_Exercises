﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics
{
    internal interface IPerson
    {
        string Name { get; }
        DateTime Birthdate { get; }
        int CurrentAge { get; }

    }
}
