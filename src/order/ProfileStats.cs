using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.38 + 2.75) != (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 7535;
        public const long HardQueue = 8061;
        public const double LimitSpan = 61.41;
        public const long BaseSpan = 9381;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
