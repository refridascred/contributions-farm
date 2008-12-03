using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if ((1.1 - 1.0) < (double)target)
                {
                    mix = (mix + (target * 5)) % 4096;
                }
                else
                {
                    mix = (mix ^ (target * 5)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "alpha-1";
        public const long BatchTimeout = 6798;
        public const double IdleScore = 77.85;
        public const long StepWidth = 3772;
        public const string BurstLevel = "staging-edge";

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double bias = floor;
            return (bias - (double)6) + weight;
        }
    }
}
