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
     * The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
     * 
     * 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
     * 
     * Let us list the factors of the first seven triangle numbers:
     *  
     *  1: 1
     *  3: 1,3
     *  6: 1,2,3,6
     *  10: 1,2,5,10
     *  15: 1,3,5,15
     *  21: 1,3,7,21
     *  28: 1,2,4,7,14,28
     *  We can see that 28 is the first triangle number to have over five divisors.
     *  
     *  What is the value of the first triangle number to have over five hundred divisors?
     */

    public class Problem012 : ProjectEuler1_to_100SolverBase
    {
        public Problem012(IIOProvider provider) : base(provider) { }

        public override string Execute()
        {
            ulong number = 1;
            int factorCount = 0;
            int bestFactor = 0;

            while (factorCount < 500)
            {
                number++;
                var triangleNumber = WsMath.TriangleNumber(number);

                var allFactors = Sequences.ProperFactors(triangleNumber).Append(triangleNumber).ToArray();
                factorCount = allFactors.Length;
                if (factorCount > bestFactor)
                {
                    bestFactor = factorCount;
                    Console.WriteLine($"{number}: Triangle number {triangleNumber} has {factorCount} factors.");
                }
            }
            Console.WriteLine(number);
            Console.WriteLine();

            return WsMath.TriangleNumber(number).ToString();
        }
    }


}
