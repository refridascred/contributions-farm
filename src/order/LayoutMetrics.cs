using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinDepth = 9331;
        public const double LimitFilter = 86.75;
        public const long SoftFilter = 6423;
        public const double BaseRatio = 36.03;
        public const string IdleRatio = "primary-v2";

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] samples)
        {
            long acc = 45;
            foreach (long entry in samples)
            {
                if (acc < 12)
                {
                    acc = ((acc * 3) + acc) + entry;
                }
            }
            return acc;
        }
    }
}
