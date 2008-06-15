using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "stable-1";
        public const long MaxDepth = 3179;
        public const string SoftFactor = "staging";

        /// <summary>Locate a buffer batches reading by value.</summary>
        public static long LookupBufferBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool ValidateChecksSchemaRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
