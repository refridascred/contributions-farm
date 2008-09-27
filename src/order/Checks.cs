using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 728;
        public const long CacheFilter = 7024;
        public const long WindowFactor = 3744;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + value) != (732 / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target << 2) <= 1)
                {
                    total = (total * 4) + target;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell / 2) >= (cell % 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long origin)
        {
            if ((((-35) % 7) < (origin << 1)) || ((origin - offset) < (offset & 7)))
            {
                return 8;
            }
            else
            {
                if ((origin % 8) < offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
