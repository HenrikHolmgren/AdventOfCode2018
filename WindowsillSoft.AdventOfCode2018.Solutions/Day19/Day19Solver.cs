﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WindowsillSoft.AdventOfCode2018.Core;
using WindowsillSoft.AdventOfCode2018.Core.Utilities;

namespace WindowsillSoft.AdventOfCode2018.Solutions.Day19
{
    public class Day19Solver : IProblemSolver
    {
        public string Description => "Day 19: Go With The Flow";

        public int SortOrder => 19;

        public void Solve()
        {
            var input = File.ReadAllLines("Day19/Day19Input.txt");

            var ipReg = (ElfCodeMachine.Register)int.Parse(input[0].Split()[1]);
            var instructions = input.Skip(1)
                .Select(p => p.Split())
                .Select(p => new ElfCodeMachine.Operation(p[0], (p.Skip(1).Select(q => int.Parse(q)).ToArray())))
                .ToArray();

            var machine = new ElfCodeMachine(instructions)
                .WithProgramCounterRegister(ipReg);

            Console.WriteLine(machine.ListProgram());

            machine.Execute();
            Console.WriteLine($"Running with R0 == 0 results in R0 being set to {machine.GetState()[0]} in {machine.ExecutedInstructions} steps.");

            int R4 = 10_551_389;
            Console.WriteLine($"Running with R0 == 1 would result in R0 being set to: {Enumerable.Range(1, R4).Where(p => R4 % p == 0).Sum()}");
            //State with [0] = 1 was run for 10 mins (runs >= 10_000_000_000) without result, so likely program has exponential runtime.
            //Resorted to manual analysis of source:
            /*
                With instruction counter in R3:
                0: ADDI; R3 <- R3 + 16    ; JMP 17
                1: SETI; R5 <- 1          ; R5 = 1
                2: SETI; R2 <- 1          ; R2 = 1
                3: MULR; R1 <- R5 * R2    
                4: EQRR; R1 <- R1 = R4    
                5: ADDR; R3 <- R1 + R3    ; IF (R4 == R2 * R5) 
                6: ADDI; R3 <- R3 + 1     
                7: ADDR; R0 <- R5 + R0    ;   R0 += R5
                8: ADDI; R2 <- R2 + 1     ; R2++
                9: GTRR; R1 <- R2 > R4    
                10: ADDR; R3 <- R3 + R1   ; IF(R2 <= R4)
                11: SETI; R3 <- 2         ;   JMP 3
                12: ADDI; R5 <- R5 + 1    ; R5++
                13: GTRR; R1 <- R5 > R4
                14: ADDR; R3 <- R1 + R3   ; IF(R5 <= R4)
                15: SETI; R3 <- 1         ;   JMP 2
                16: MULR; R3 <- R3 * R3   ; HALT
                17: ADDI; R4 <- R4 + 2
                18: MULR; R4 <- R4 * R4
                19: MULR; R4 <- R3 * R4   
                20: MULI; R4 <- R4 * 11   ; R4 = ((R4 + 2) ^ 2) * 19 * 11 // R4 = (R4 + 2)^2 * 209
                21: ADDI; R1 <- R1 + 6
                22: MULR; R1 <- R1 * R3
                23: ADDI; R1 <- R1 + 21   ; R1 = (R1 + 6) * 22 + 21; // R1 = 22 * R1 + 153
                24: ADDR; R4 <- R4 + R1   ; R4 += R1;
                25: ADDR; R3 <- R3 + R0   ; JMP +R0
                26: SETI; R3 <- 0         ; JMP 1
                27: SETR; R1 <- R3        
                28: MULR; R1 <- R1 * R3
                29: ADDR; R1 <- R3 + R1
                30: MULR; R1 <- R3 * R1
                31: MULI; R1 <- R1 * 14
                32: MULR; R1 <- R1 * R3   ; R1 = 27 * 28 * 2 * 14 // R1 = 21168
                33: ADDR; R4 <- R4 + R1   ; R4 += 21168;
                34: SETI; R0 <- 0         ; R0 = 0
                35: SETI; R3 <- 0         ; JMP 1

            //Pseudo-assembly:
                :init
                R4 = 836;
                R1 = 153;
                R4 += R1; // = 989
                IF(R0 == 1)
                  R1 = (27 * 28 + 29) * 30 * 14 * 32; // = 10_550_400;
                  R4 += R1 // = 10_551_389;  

                R5 = 1
                //[0 153 0 1 989 1] OR [0 10550400 0 1 10551389 1]  
                :loop1
                R2 = 1
                :loop2

                IF (R4 == R2 * R5)
                  R0 += R5
                R2++

                IF(R2 <= R4)
                  JMP loop2
                R5++

                IF(R5 <= R4)
                  JMP loop1
                HALT

            //Pseudo-C#
                
                R4 = 836;
                R1 = 153;
                R4 += R1; // = 989
                
                IF(R0 == 1) {
                  R1 = (27 * 28 + 29) * 30 * 14 * 32; // = 10_550_400;
                  R4 += R1 // = 10_551_389;  
                }

                R5 = 1;
                do {
                    R2 = 1;
                    do {
                        if (R4 == R2 * R5)
                            R0 += R5;
                        R2++;
                    }
                    while (R2 <= R4);
                    R5++;
                }
                while (R5 <= R4);

            //Or a bit easier to read:
            
                int R4 = 989;
                if(R0 = 1)
                    R4 = 10_551_389;            
                R0 = 0; 
            
                for (int R5 = 1; R5 <= R4; R5++)
                    for (int R2 = 1; R2 <= R4; R2++)
                        if(R4 == R2 * R5)
                            R0 += R5;

            //Which is the same as
                int R4 = R0 == 0 ? 989 : 10_551_389;
                R0 = Enumerable.Range(1, R4).Where(p => R4 % p == 0).Sum();
             */
        }
    }
}
