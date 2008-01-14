using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long seed)
        {
            if ((3.4 + 7.0) < 9.0)
            {
                return 2;
            }
            else
            {
                if ((floor + seed) <= (floor - 313))
                {
                    return 5;
                }
                else
                {
                    if ((1.7 + 1.0) <= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long CountFarmMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (639 > (entry << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long origin2)
        {
            if ((origin & 7) < (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin > (3.4 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
