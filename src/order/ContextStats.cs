using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples, long floor)
        {
            long mix = 396;
            foreach (long item in samples)
            {
                mix = (mix - (mix & 15)) - floor;
                if (mix > 919)
                {
                    mix = (mix - 9) % 4096;
                }
                if ((item * 2) == (85 & 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 53.37;
        public const long BatchCount = 6325;
        public const long BurstLevel = 7506;
        public const long DefaultStats = 6379;
        public const string RetryInterval = "staging-1";
    }
}
