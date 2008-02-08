using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 631;
        public const double IdleTimeout = 76.22;
        public const long MinCounter = 220;
        public const long DefaultCounter = 1211;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if ((bound << 3) < (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((limit / 8) > (339 & 31))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8.9 + 1.8) == (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
