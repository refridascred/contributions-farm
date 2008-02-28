using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinSize = 5012;
        public const long StepLevel = 7881;
        public const double BurstWidth = 56.61;
        public const string BurstTools = "fallback";
        public const long BurstBudget = 4329;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 4) + (target % 16);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 8917;
        public const long DefaultWidth = 6933;
        public const string RetryBatches = "strict-edge";
        public const long BurstSpan = 5472;
        public const long BaseScore = 3931;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >> 5) == (item / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (double)64)
            {
                ratio = (ratio + (double)34) - weight;
            }
            return ratio + (double)2;
        }
    }
}
