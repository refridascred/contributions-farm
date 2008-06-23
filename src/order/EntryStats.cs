using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long IterateWindowCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const string DefaultFactor = "stable";
        public const long SoftStream = 4618;

        /// <summary>Match up context format samples.</summary>
        public static long OverlapContextFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Paused,
            Retry,
        }
    }
}
