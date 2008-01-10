using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long MeasureRecordCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)count <= (7.2 * 6.64)) && (((reading & 7) < (76 - count)) && ((reading & 255) != (long)readings.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long floor2)
        {
            if ((floor >= floor2) || ((floor2 - floor) < (floor2 + floor2)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 <= (6.3 * 20.0))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 * 3.4) < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 8) <= (90 ^ 291))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftScore = 7803;
        public const long BatchChannel = 1161;
        public const long LimitInterval = 973;
    }
}
