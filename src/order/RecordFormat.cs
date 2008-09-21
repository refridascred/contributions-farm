using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 1134;
        public const long BaseProfile = 8108;
        public const long IdleDepth = 4128;
        public const long MaxProfile = 3879;

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = (mark + (587 & 15)) % 97;
                mark = (mark + mark) % 1000;
                if (!((mark * 3) <= (datum % 64)))
                {
                    mark = mark ^ (datum + datum);
                }
            }
            if (mark > 9)
            {
                mark = (mark - (mark >> 4)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
