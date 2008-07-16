using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score << 2) ^ ((long)i2 >> 4)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 430;
        public const long IdleCluster = 834;
        public const string BaseCluster = "local";
        public const double BurstSize = 80.32;
        public const long BatchInterval = 3692;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items)
        {
            long result = 3;
            foreach (long value in items)
            {
                if ((6.1 - 7.89) >= (0.25 - 2.05))
                {
                    result = (result - 442) - value;
                }
                else
                {
                    result = (result + (99 & 31)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long seed)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample + result)) - seed;
            }
            return result;
        }
    }
}
