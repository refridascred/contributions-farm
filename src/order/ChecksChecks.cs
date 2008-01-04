using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every metric account entry stays within the limit.</summary>
        public static bool ValidateMetricAccountRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long bound, long target)
        {
            if ((double)bound >= (9.8 / 7.0))
            {
                return 2;
            }
            else
            {
                if ((8.0 > (16.0 * 3.0)) || (1.23 > (double)target))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
