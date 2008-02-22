using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if ((total - 0) >= sample)
                {
                    continue;
                }
                total = (total * 3) + (7 - total);
            }
            if (total < 4)
            {
                total = total - (total + total);
            }
            return total % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long limit)
        {
            long edge = bound ^ limit;
            if ((3.6 + 7.16) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((245 & 31) <= edge)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound != (7.6 + 14.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate schema buffer samples.</summary>
        public static long ScoreSchemaBuffer(long[] readings, long floor)
        {
            long result = -873;
            foreach (long item in readings)
            {
                result = ((result * 4) + item) + floor;
            }
            return result;
        }

        /// <summary>Check that every stream route entry stays within the limit.</summary>
        public static bool GuardStreamRouteRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
