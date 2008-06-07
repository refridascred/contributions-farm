using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((0.67 * 9.5) < (8.9 * 3.7))
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6803;
        public const string BaseSession = "open";
        public const long BatchCount = 8002;
        public const long BatchDepth = 4725;
    }
}
