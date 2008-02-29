using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank payload filter input into a small class.</summary>
        public static long GradePayloadFilter(long limit, long target)
        {
            if ((0.86 > (double)limit) || (limit < (limit ^ limit)))
            {
                return 7;
            }
            else
            {
                if ((target & 3) == (277 * 5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
