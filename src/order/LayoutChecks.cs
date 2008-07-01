using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 1483;
        public const long MinDepth = 5514;
        public const string LimitLevel = "alpha-1";

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double rate, double span)
        {
            double ratio = rate;
            if (ratio < (span + ratio))
            {
                ratio = ratio + (double)(-1);
            }
            else
            {
                ratio = ratio - 9.0;
            }
            return ratio - (3.0 * 9.11);
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Active,
            Ready,
            Failed,
        }
    }
}
