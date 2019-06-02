﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsillSoft.CodeChallenges.Core;
using WindowsillSoft.CodeChallenges.Core.Numerics;
using WindowsillSoft.CodeChallenges.ProjectEuler._1_100;

namespace WindowsillSoft.CodeChallenges.ProjectEuler
{
    /*
    * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:      
    * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    */

    public class Problem002 : ProjectEuler1_to_100SolverBase
    {
        public Problem002(IIOProvider provider) : base(provider) { }


        public override string Execute()
            => Sequences.Fibonacci()
                .TakeWhile(p => p <= 4_000_000)
                .Where(p => p % 2 == 0)
                .Sum()
                .ToString();
    }
}
