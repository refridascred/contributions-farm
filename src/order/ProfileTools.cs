using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values, long target)
        {
            long state = 44;
            foreach (long value in values)
            {
                state = (state - (state ^ 334)) - value;
                if ((state / 3) > target)
                {
                    state = (state + (target & 63)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftLevel = 7102;
        public const double MaxDepth = 86.12;
        public const long HardOrder = 5849;
        public const string IdleOrder = "alpha-v2";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (floor <= (hits / 2))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
