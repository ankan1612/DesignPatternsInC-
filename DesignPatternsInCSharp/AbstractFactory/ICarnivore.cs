﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AbstractFactory
{
    //This is the abstract product B
    interface ICarnivore
    {
        void eat(IHerbivore h);
    }
}
