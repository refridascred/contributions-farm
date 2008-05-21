using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits <= 18.0)
                {
                    hits = ((hits + 1) + sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "fallback-1";
        public const long WindowTimeout = 5627;
        public const long MaxChannel = 2343;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 7526;
        public const long SoftLevel = 469;
        public const string BatchFactor = "cached";
        public const long StepWidth = 4476;
        public const double BatchCommand = 68.66;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((datum % 60) > (datum - step)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
