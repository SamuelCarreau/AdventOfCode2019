﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.FetchInputStrategy
{
    public interface IFetchInputStrategy
    {
        string[] ReadFile(string fileName);
    }
}
