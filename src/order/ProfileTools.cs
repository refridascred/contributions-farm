using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long floor)
        {
            if ((floor * 3) < offset)
            {
                return 8;
            }
            else
            {
                if ((offset - floor) != (floor * 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5055;
        public const long MinSize = 1710;
        public const long BatchWindow = 5622;
    }
}
