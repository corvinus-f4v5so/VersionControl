﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsimulation.Entities
{
    public class DeathProbability
    {
        public bool Gender { get; set; }
        public int Age { get; set; }
        public double DeathProb { get; set; }
    }
}
