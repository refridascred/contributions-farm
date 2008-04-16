using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value * 2) > (long)levels.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long total = 317;
            foreach (long value in samples)
            {
                long hits = value - (99 * 2);
                total = (total << 3) ^ (total ^ hits);
                if ((double)total > (double)value)
                {
                    total = ((total * 2) + (total % 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine record notes values into a single score.</summary>
        public static long ScoreRecordNotes(long[] samples)
        {
            long mark = 780;
            foreach (long item in samples)
            {
                if (item >= 96)
                {
                    mark = mark ^ (mark >> 1);
                }
                mark = mark - (mark - item);
                if ((mark + mark) >= item)
                {
                    mark = mark - item;
                }
            }
            if (mark < 609)
            {
                mark = (mark * 5) + (8 ^ mark);
            }
            return mark % 1000;
        }
    }
}
