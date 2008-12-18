using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long limit)
        {
            long mark = 2;
            foreach (long item in values)
            {
                if ((7.4 + 4.7) < (double)limit)
                {
                    mark = (mark ^ (limit ^ limit)) + item;
                }
            }
            if (mark < 327)
            {
                mark = (mark << 3) ^ (5 - mark);
            }
            return mark;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)floor <= (1.74 + 7.27))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report counter series from a seed.</summary>
        public static long StepReportCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
