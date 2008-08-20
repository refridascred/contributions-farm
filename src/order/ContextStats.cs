using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 90.18;
        public const long WindowWidth = 4817;
        public const string DefaultTools = "alpha-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((418 + bound) != (value / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((total > ((long)i - limit)) && ((limit + limit) <= (total ^ (long)i)))
                {
                    total = total - total;
                }
                total = ((total << 3) ^ ((long)i >> 5)) % 1000;
                if (limit < (limit / 4))
                {
                    total = (total ^ (77 + (long)i)) % 4096;
                    total = (total - (total << 2)) % 4096;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
