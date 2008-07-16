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

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings, long floor)
        {
            long state = 84;
            foreach (long entry in readings)
            {
                state = ((((state * 5) + 901) % 4096) ^ entry) + floor;
            }
            if (state > 7)
            {
                state = ((state * 5) + (state / 2)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Locked,
            Paused,
        }
    }
}
