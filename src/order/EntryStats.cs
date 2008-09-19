using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached-1";
        public const long WindowFactor = 7741;
        public const long CacheDepth = 9233;
        public const long IdleBudget = 282;
        public const long CacheTools = 5101;

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 5067;
        public const long IdleBatches = 1059;
        public const long WindowInterval = 6818;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - 2) <= (matches + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(((17.0 * 3.1) >= (double)limit) || ((46 * 2) >= (mark + 16))))
                {
                    mark = (mark + (limit - limit)) % 97;
                    mark = (mark + (mark / 8)) % 255;
                }
                mark = (mark ^ (long)i) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a farm batch figure with a bias.</summary>
        public static double ProjectFarmBatch(double rate, double span)
        {
            double load = span;
            return (load + span) + rate;
        }
    }
}
