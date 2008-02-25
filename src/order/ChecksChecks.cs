using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a graph session reading by value.</summary>
        public static long FindGraphSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long seed)
        {
            if ((2.39 / 2.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin / 3) >= (origin % 60))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (2.2 - 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 8) < (origin + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= (seen << 3))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
