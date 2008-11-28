using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitFactor = "open-v2";
        public const long RetryRatio = 3324;
        public const double IdleGraph = 10.43;
        public const double BatchGraph = 73.5;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a record farm counter forward.</summary>
        public static long RollRecordFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 2) ^ (score % 12)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
