using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long MeasureBatchesReportHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long floor2)
        {
            if (floor >= ((-752) + (-569)))
            {
                return 8;
            }
            else
            {
                if ((6.69 + 8.0) <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long origin, long floor)
        {
            long slot = origin + floor;
            if (origin <= floor)
            {
                return 7;
            }
            else
            {
                if ((double)slot >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (((floor ^ floor) < (origin + slot)) || ((floor - slot) != (9 >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
