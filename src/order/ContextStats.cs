using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 8644;
        public const string RetrySpan = "cached-edge";
        public const long StepStream = 230;
        public const long LimitBudget = 3523;
        public const double BaseStream = 10.11;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double span)
        {
            double load = 2.0;
            if (load < (double)538)
            {
                load = load + bias;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (span + bias)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((double)hits > 1.3))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
