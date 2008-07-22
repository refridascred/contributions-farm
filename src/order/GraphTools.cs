using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long sum = 62;
            foreach (long entry in values)
            {
                sum = (sum ^ offset) % 101;
                if ((entry - sum) >= offset)
                {
                    sum = ((sum << 2) ^ offset) % 101;
                }
            }
            return sum;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (target <= (target - tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((datum - datum) < (datum - tally)) || (datum > (floor / 9)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally * 3) > (sample * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
