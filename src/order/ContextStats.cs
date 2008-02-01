using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback-v2";
        public const double DefaultInterval = 5.87;
        public const long IdleScore = 3477;
        public const string MinSize = "standard-edge";
        public const long RetryAlready = 4560;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long CompareSessionClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
