using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Idle,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items, long origin)
        {
            long mark = 995;
            foreach (long item in items)
            {
                mark = ((mark + 2) + item) + origin;
                if ((9 ^ 829) > mark)
                {
                    mark = mark ^ (mark - 5);
                }
            }
            return mark;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
