using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6651;
        public const double HardCount = 33.91;
        public const long RetrySchema = 8400;

        /// <summary>Derive the next account graph value from a seed.</summary>
        public static long IterateAccountGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((result - result) != (result + result)))
                {
                    result = (result ^ 6) % 1000;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}
