﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics
{
    internal interface IPerson
    {
        string Name { get; set; }
        DateTime Birthdate { get; set; }
        int Age { get; set; }

    }
}
