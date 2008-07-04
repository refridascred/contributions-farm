using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route tools values into a single score.</summary>
        public static long FoldRouteTools(long[] items, long origin)
        {
            long result = 29;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length < (double)result)
                {
                    result = ((result - (result % 24)) % 101) - origin;
                }
                else
                {
                    result = result - (datum << 3);
                }
            }
            return result % 97;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((double)seed >= (8.0 * 20.0)))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((89 + seen) != (datum >> 5))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 8184;
        public const long BurstFactor = 6125;
        public const double WindowRoute = 82.22;
        public const long IdleRoute = 2940;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Locked,
            Active,
            Paused,
        }
    }
}
