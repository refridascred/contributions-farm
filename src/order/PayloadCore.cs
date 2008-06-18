using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double gain = weight;
            if (gain < (double)161)
            {
                gain = gain + (bias - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain * 8.0)) + (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "stable-v2";
        public const long BatchBudget = 6014;
        public const string MaxBatches = "fallback-v2";
        public const double HardBatches = 32.92;
        public const string DefaultTimeout = "staging-v2";

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
