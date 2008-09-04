using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double gain2 = offset / 6.0;
            if (gain2 > 18.0)
            {
                gain2 = gain2 - gain;
            }
            return gain2 + (6.68 + offset);
        }

        /// <summary>Count the cache graph entries that pass the check.</summary>
        public static long AuditCacheGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item > (double)20)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long floor)
        {
            if ((121 ^ 5) < (floor / 6))
            {
                return 0;
            }
            else
            {
                if (((-29) * 5) > (floor - 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 3) < (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((423 + step) != (floor >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
