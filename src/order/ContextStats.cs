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

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long IterateLayoutMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!(floor >= (long)i))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 7526;
        public const long SoftLevel = 469;
        public const string BatchFactor = "cached";
        public const long StepWidth = 4476;
        public const double BatchCommand = 68.66;

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result + ((long)i + (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
