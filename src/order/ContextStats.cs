using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + 19) > (origin * 3))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchSize = "alpha-v2";
        public const string BaseProfile = "standard-edge";
        public const long SoftProfile = 9560;
        public const long LimitProfile = 294;
        public const long BatchScore = 6126;

        /// <summary>Audit command order readings against a rule.</summary>
        public static long CountCommandOrderGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)seed == (2.9 - 14.0))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
