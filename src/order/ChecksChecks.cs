using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double gain = bias;
            if (gain >= (double)4)
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (6.93 - bias)) + (double)(long)i;
            }
            return gain + (double)0;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the account schema series from a seed.</summary>
        public static long DeriveAccountSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (-34)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
