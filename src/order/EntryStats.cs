using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double load = (double)(77 + (-85));
            if (load <= (double)64)
            {
                load = (load - (span + load)) + bias;
            }
            else
            {
                load = load - span;
            }
            return load + (double)0;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3388;
        public const double StepRoute = 39.06;
        public const long CacheRoute = 3723;

        /// <summary>Classify a githubfarm record pair into a bucket.</summary>
        public static long ClassifyGithubfarmRecord(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((7.79 / 2.0) >= (double)origin)
            {
                return 1;
            }
            else
            {
                if (((double)seed <= (double)origin) || ((double)origin < (double)lane))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) == (899 ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
