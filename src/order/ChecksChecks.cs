using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 36.24;
        public const long BurstToken = 3221;
        public const long DefaultTimeout = 1917;
        public const string CacheToken = "fallback";

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((origin << 1) < (origin << 2))
            {
                return 8;
            }
            else
            {
                if (((double)lane != (double)bound) || ((double)origin < 9.41))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 3) > (629 * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
