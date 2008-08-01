using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter counter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the profile payload entries that pass the check.</summary>
        public static long TallyProfilePayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count & 63) != (sample * 2)) || !((5.14 * 14.0) >= 9.36))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long AuditClusterQueueHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((0.23 - 8.9) <= (double)hits))
                {
                    hits = ((hits + 2) + reading) + bound;
                }
            }
            return hits;
        }
    }
}
