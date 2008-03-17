using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long CountGraphSchemaGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)item > 2.9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - (4 & 7)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
