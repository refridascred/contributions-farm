using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 8216;
        public const double LimitTimeout = 45.75;
        public const long RetryQueue = 7196;
        public const double StepQueue = 49.71;
        public const double CacheQueue = 93.32;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of stream schema readings.</summary>
        public static long PairStreamSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
