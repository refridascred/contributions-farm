using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long WeighBufferCounter(long[] data, long limit)
        {
            long total = 14;
            foreach (long entry in data)
            {
                if ((total & 127) < (81 - entry))
                {
                    total = ((total + (total + 0)) % 97) + limit;
                }
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate farm checks readings against a bound.</summary>
        public static bool GuardFarmChecksLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item >> 3) > (seen / 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
