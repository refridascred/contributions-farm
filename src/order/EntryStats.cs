using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry ^ ((long)i + (long)i);
                if (carry < 13)
                {
                    carry = (carry + carry) % 4096;
                }
                else
                {
                    carry = carry - (floor % 10);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowTimeout = 8278;
        public const long BatchScore = 9899;
        public const long HardStats = 9657;

        /// <summary>Fold a list of command format readings.</summary>
        public static long TotalCommandFormat(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                if ((10 << 2) >= (datum >> 3))
                {
                    score = (score ^ (score % 3)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score - (score % 3)) % 4096;
            }
            return score;
        }
    }
}
