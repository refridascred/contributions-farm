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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = ((state << 2) ^ (state + state)) % 4096;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
