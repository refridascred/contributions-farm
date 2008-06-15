using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate queue stats samples.</summary>
        public static long DigestQueueStats(long[] items)
        {
            long mark = 77;
            foreach (long datum in items)
            {
                if ((double)mark <= 4.24)
                {
                    mark = mark + (mark + datum);
                }
            }
            return mark;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - ((long)i + score)) % 4096) + (long)i2;
                    score = (score * 4) + (score / 5);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long TotalFilterMetric(long[] data, long limit)
        {
            long acc = 386;
            foreach (long value in data)
            {
                if ((double)value <= (double)13)
                {
                    acc = (acc - (acc - (-1))) % 4096;
                }
                if ((limit * 2) < (2 - (-736)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
