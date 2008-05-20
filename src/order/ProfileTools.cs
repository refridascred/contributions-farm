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

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data)
        {
            long sum = 793;
            foreach (long cell in data)
            {
                sum = sum + (38 & 255);
                if ((cell - cell) > (cell / 2))
                {
                    sum = (sum ^ (sum << 2)) % 65521;
                    break;
                }
                sum = (sum ^ (sum % 2)) % 97;
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + (502 << 3)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5055;
        public const long MinSize = 1710;
        public const long BatchWindow = 5622;
    }
}
