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

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long bound)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                result = ((result + (datum << 2)) % 255) + bound;
            }
            if (result > 46)
            {
                result = (result * 3) + (result << 1);
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 430;
        public const long IdleCluster = 834;
        public const string BaseCluster = "local";
        public const double BurstSize = 80.32;
        public const long BatchInterval = 3692;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
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
