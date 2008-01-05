using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long TallyMetricContributiMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9 % 16) == (value & 127))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long origin)
        {
            if (origin > (origin + floor))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
