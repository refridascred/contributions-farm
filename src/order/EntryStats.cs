using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstFactor = 6883;
        public const long DefaultDepth = 9288;
        public const long HardLevel = 9302;
        public const string StepRatio = "fallback-1";
        public const long LimitSpan = 1945;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long PairGraphSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
