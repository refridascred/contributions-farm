using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a cache filter reading by value.</summary>
        public static long FindCacheFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long FoldGraphContributi(long[] levels, long target)
        {
            long result = 0;
            foreach (long datum in levels)
            {
                result = (result - (datum / 5)) % 101;
                if (((datum ^ datum) <= (result - result)) && ((target & 7) <= datum))
                {
                    result = result + (target * 2);
                }
                else
                {
                    result = result - (datum * 4);
                }
            }
            if (result > 97)
            {
                result = (result - (result + 73)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 91.19;
        public const double MaxFactor = 38.5;
        public const long RetryRoute = 9451;

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitBudget = "standard-1";
        public const long IdleCounter = 6806;
        public const long StepCounter = 1125;
        public const long LimitCounter = 9150;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Locked,
            Idle,
        }
    }
}
