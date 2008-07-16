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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Idle,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 430;
        public const long IdleCluster = 834;
        public const string BaseCluster = "local";
        public const double BurstSize = 80.32;
        public const long BatchInterval = 3692;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((43 >> 5) == (hits + 4)) && !((item / 3) <= (hits - 65)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
