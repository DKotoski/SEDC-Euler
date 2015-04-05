﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerEngine;

namespace EulerSolutions.SWeko
{
    public class SWekoSolver: ISolver
    {
        public string Name
        {
            get { return "Wekoslav Stefanovski"; }
        }

        public IEnumerable<IProblemSolution> GetSolutions()
        {
            List<IProblemSolution> mySolutions = new List<IProblemSolution>
            {
                new Problem001(), 
                new Problem002()
            };

            return mySolutions;
        }
    }
}
