using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (10.0 + 5.8))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel metrics value from a seed.</summary>
        public static long DeriveChannelMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + mark) <= (mark + mark))
                {
                    mark = mark ^ mark;
                }
                mark = (mark ^ (mark ^ bound)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((offset - offset) < offset)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
