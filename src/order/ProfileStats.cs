using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 74.16;
        public const long HardDepth = 1557;
        public const long IdleSize = 807;
        public const long MinSupport = 1042;
        public const long DefaultRatio = 8743;

        /// <summary>Fold a list of route metric readings.</summary>
        public static long TallyRouteMetric(long[] samples)
        {
            long mix = 78;
            foreach (long cell in samples)
            {
                mix = ((mix * 4) + (167 & 15)) % 101;
                if ((mix >> 3) == (cell >> 4))
                {
                    mix = ((mix * 2) + (cell & 7)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
