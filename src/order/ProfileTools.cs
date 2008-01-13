using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 6600;
        public const long LimitSchema = 4397;
        public const string WindowSchema = "fallback";
        public const long BatchSchema = 2464;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long anchor = 579;
            foreach (long item in values)
            {
                anchor = anchor - (751 + item);
                if (((item << 2) <= anchor) && ((item % 10) == (anchor & 7)))
                {
                    anchor = (anchor * 2) + (item >> 1);
                }
                if ((15.0 + 5.56) > (double)item)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool VerifyLayoutMetricsLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
