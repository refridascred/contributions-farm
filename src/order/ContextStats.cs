using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxSize = "stable-v2";
        public const string BurstWidth = "latest-1";
        public const long LimitRatio = 6485;
        public const long LimitLevel = 208;
        public const string MaxRecord = "cached-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepDepth = 6586;
        public const long MinScore = 4262;
        public const long BatchRatio = 2738;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Fold a list of checks graph readings.</summary>
        public static long DigestChecksGraph(long[] readings)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (sum ^ (datum + sum)) % 255;
            }
            return sum;
        }
    }
}
