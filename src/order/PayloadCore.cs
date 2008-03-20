using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph session readings against a rule.</summary>
        public static long TallyGraphSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((5.7 * 8.4) > (double)seen))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Grade a support cache value against two limits.</summary>
        public static long GradeSupportCache(long floor, long target)
        {
            long edge = floor - target;
            if ((double)floor > (12.0 - 9.93))
            {
                return 4;
            }
            else
            {
                if ((edge % 100) > (edge + 3))
                {
                    return 5;
                }
                else
                {
                    if (!((floor - floor) <= (edge - edge)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + edge) <= 482)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter already readings against a rule.</summary>
        public static long AuditFilterAlreadyHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((11.0 + 16.0) >= (double)count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (0.4 * 1.0))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
