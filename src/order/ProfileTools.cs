using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + limit) != (sample + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 71.03;
        public const double MaxLayout = 14.41;
        public const long BurstSize = 3686;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                anchor = (anchor - anchor) % 255;
                if ((anchor + datum) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (44 + datum)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (datum + datum)) % 101;
                }
            }
            return anchor;
        }
    }
}
