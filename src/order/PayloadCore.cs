using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = -81;
            foreach (long datum in levels)
            {
                if ((acc - datum) != (acc * 2))
                {
                    acc = acc ^ datum;
                }
            }
            if (acc > 7)
            {
                acc = acc - (acc & 7);
            }
            return acc;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Derive the next account batches value from a seed.</summary>
        public static long SeriesAccountBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 3) + 761;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
