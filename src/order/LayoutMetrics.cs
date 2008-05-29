using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 9775;
        public const double MaxDepth = 28.86;
        public const double SoftLevel = 3.79;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen ^ cell) <= (seed ^ cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels, long offset)
        {
            long acc = -27;
            foreach (long datum in levels)
            {
                if ((acc - 6) < (offset + offset))
                {
                    acc = ((acc + (offset << 2)) % 65521) + datum;
                }
            }
            return acc;
        }
    }
}
