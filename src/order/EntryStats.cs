using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long TallyCommitsFarmMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (limit >= (limit ^ sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
