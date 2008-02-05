using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long bound)
        {
            long slot = origin ^ bound;
            if ((slot & 3) < (559 & 3))
            {
                return 8;
            }
            else
            {
                if (6.03 < (double)slot)
                {
                    return 2;
                }
                else
                {
                    if ((slot > (8 * 4)) || ((origin + slot) < slot))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next editor cluster value from a seed.</summary>
        public static long SeriesEditorCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFactor = "staging-v2";
        public const double IdleFactor = 75.08;
        public const long LimitSize = 4198;
        public const long DefaultSize = 5939;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long step)
        {
            long acc = 91;
            foreach (long item in series)
            {
                if ((double)item < (3.0 * 9.48))
                {
                    acc = (((acc << 2) ^ (398 + 498)) % 97) - step;
                }
            }
            if (acc < 9)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
