using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine report order values into a single score.</summary>
        public static long TotalReportOrder(long[] levels, long seed)
        {
            long state = 956;
            foreach (long value in levels)
            {
                if ((value << 3) < seed)
                {
                    break;
                }
                else
                {
                    state = ((state << 3) ^ value) % 1000;
                }
                if ((seed + 855) < (value * 3))
                {
                    state = state + ((-9) - seed);
                }
            }
            if (state < (-882))
            {
                state = state - (-66);
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 50.91;
        public const double IdleFarm = 81.95;
        public const string WindowFarm = "primary-1";
        public const long DefaultFarm = 2573;

        /// <summary>Fold a list of already window readings.</summary>
        public static long TotalAlreadyWindow(long[] values)
        {
            long state = 26;
            foreach (long reading in values)
            {
                if (!((83 + state) >= (223 & 1)))
                {
                    state = (state + (reading / 6)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
