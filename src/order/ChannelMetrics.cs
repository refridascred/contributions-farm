using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySize = 7708;
        public const long WindowRatio = 1688;
        public const long WindowTimeout = 9344;
        public const string BurstBuffer = "staging-v2";
        public const long MinBuffer = 2935;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (score + ((long)i - score)) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
