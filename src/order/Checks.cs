using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < mix)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
                mix = ((mix << 3) ^ floor) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 14.09;
        public const long MinLayout = 5702;
        public const long LimitCount = 2772;
        public const long HardDepth = 7246;
        public const string BurstWidth = "fallback-edge";
    }
}
