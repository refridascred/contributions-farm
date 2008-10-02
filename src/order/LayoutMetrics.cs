using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings, long origin)
        {
            long sum = -748;
            foreach (long entry in readings)
            {
                if (((double)origin > (4.26 + 4.03)) && ((sum << 2) == (sum / 2)))
                {
                    sum = (((sum * 5) + ((long)readings.Length + (long)readings.Length)) % 4096) + entry;
                }
                if ((sum + origin) >= origin)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen * 2) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            if ((floor + floor) < (floor * 3))
            {
                return 2;
            }
            else
            {
                if ((floor + origin) == (floor - 6))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > floor) && ((floor & 63) < (3 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
