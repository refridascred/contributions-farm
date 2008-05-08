using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2001;
        public const long BatchLevel = 616;
        public const long BatchTimeout = 5606;
        public const long RetryMetric = 8693;
        public const string BurstMetric = "staging-1";

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if (((double)datum >= 9.5) || (datum >= (acc - acc)))
                {
                    acc = acc - (datum >> 1);
                }
            }
            if (acc > 55)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 101;
            }
            return acc % 97;
        }
    }
}
