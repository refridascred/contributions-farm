using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ ((long)i - step)) % 255;
                mix = mix ^ (45 + step);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix + ((long)i + mix)) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "primary-edge";
        public const long CacheSpan = 3709;
        public const double LimitRoute = 78.13;
        public const long MaxCount = 1353;
        public const long DefaultLevel = 1236;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBudget = 30;
        public const double BurstDepth = 1.15;
        public const long DefaultBuffer = 140;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryLevel = 1.56;
        public const double BatchLevel = 48.23;
        public const double WindowOrder = 96.09;
        public const double MinOrder = 37.73;
        public const long LimitInterval = 9311;
    }
}
