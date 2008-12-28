using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitRatio = "strict";
        public const long WindowBuffer = 8497;
        public const long StepBuffer = 4459;
        public const long WindowFactor = 8000;
        public const string BurstBuffer = "primary-1";

        /// <summary>Rank token batch input into a small class.</summary>
        public static long SortTokenBatch(long offset, long step)
        {
            if ((step - step) == (step * 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 75.89;
        public const long SoftPayload = 361;
        public const long HardLevel = 3474;
        public const long LimitScore = 947;
        public const long CachePayload = 3461;

        /// <summary>Look up the position of a farm entry sample.</summary>
        public static long LocateFarmEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Locked,
            Failed,
        }
    }
}
