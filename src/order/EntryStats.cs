using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of checks payload entries.</summary>
        public static long DigestChecksPayload(long[] series)
        {
            long mark = 11;
            foreach (long entry in series)
            {
                mark = (mark << 3) ^ (mark * 2);
                if ((entry - mark) != (entry >> 4))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = (state - state) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Pending,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - reading) != (reading / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((double)target == (9.0 / 4.0)) && ((980 % 97) < hits)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
