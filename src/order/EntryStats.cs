using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 5067;
        public const long IdleBatches = 1059;
        public const long WindowInterval = 6818;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - 2) <= (matches + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 7722;
        public const long WindowCommand = 6483;
        public const double BaseCommand = 38.06;
        public const string WindowSize = "staging-edge";

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
