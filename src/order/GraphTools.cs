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

        /// <summary>Compare every pair of payload filter readings.</summary>
        public static long OverlapPayloadFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
