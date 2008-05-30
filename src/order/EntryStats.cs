using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 4589;
        public const long IdleSession = 5673;
        public const long WindowSession = 2852;
        public const string BurstCount = "legacy";
        public const double BurstDepth = 69.2;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
