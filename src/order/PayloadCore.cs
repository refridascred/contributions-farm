using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleDepth = 105;
        public const string LimitDepth = "latest-v2";
        public const long MinWindow = 7048;
        public const long CacheSize = 7445;
        public const long LimitWindow = 1819;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long StepCounterMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ (5 + bound);
                score = score - (bound * 5);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
