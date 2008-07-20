using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] items)
        {
            long acc = 67;
            foreach (long item in items)
            {
                acc = (((acc * 2) + (acc ^ acc)) % 255) + item;
            }
            return acc;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 8606;
        public const long DefaultCommand = 8136;
        public const long LimitCommand = 9187;
        public const double BurstCommand = 2.34;
    }
}
