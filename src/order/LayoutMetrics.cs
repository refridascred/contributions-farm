using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long carry = 367;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 2) ^ ((long)i + carry)) % 255;
                }
                if ((item ^ item) != (235 + item))
                {
                    carry = (carry + (carry ^ item)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "cached-v2";
        public const long BurstFactor = 7934;
        public const long LimitBatch = 7211;
        public const long BaseBatch = 534;
        public const double CacheDepth = 86.74;
    }
}
