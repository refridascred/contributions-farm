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

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Ready,
            Paused,
            Pending,
            Failed,
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
