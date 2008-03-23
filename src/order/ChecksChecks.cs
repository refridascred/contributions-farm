using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long limit, long floor)
        {
            long cur = limit + floor;
            if ((floor >> 2) >= (limit + floor))
            {
                return 5;
            }
            else
            {
                if ((limit - limit) > (limit - 9))
                {
                    return 6;
                }
                else
                {
                    if (((double)cur >= (double)0) || ((limit ^ 8) <= cur))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Done,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally >= (double)122)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
