﻿using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTX
{
    public class Class1 : IConfig
    {
        public bool IsEnabled {  get; set; } = true;
        public bool Debug {  get; set; } = false;
    }
}
