using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            New,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 5548;
        public const long DefaultRoute = 7113;
        public const long CacheRoute = 9556;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry ^ entry) > matches)
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
