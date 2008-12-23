using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 3004;
        public const long StepReport = 8634;
        public const long MaxReport = 3315;
        public const string WindowFactor = "fallback-edge";

        /// <summary>Digest a series of buffer token entries.</summary>
        public static long TallyBufferToken(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                acc = (((acc << 3) ^ 31) % 97) + value;
            }
            return acc % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardTimeout = "strict-edge";
        public const string LimitChecks = "standard";
        public const double WindowSize = 51.48;
        public const long MaxFactor = 828;
        public const long DefaultInterval = 4307;
    }
}
