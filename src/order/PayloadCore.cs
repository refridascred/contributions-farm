using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long mark = 93;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (bound & 63);
                if ((bound - entry) < (bound << 2))
                {
                    mark = (mark + (mark - mark)) % 101;
                    mark = mark + (631 + (long)readings.Length);
                }
                else
                {
                    mark = ((mark * 2) + (mark - entry)) % 101;
                }
                mark = mark + (bound - mark);
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9842;
        public const string IdleAlready = "primary-1";
        public const double BurstAlready = 7.58;
        public const long LimitBudget = 781;
        public const long HardRatio = 6570;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
