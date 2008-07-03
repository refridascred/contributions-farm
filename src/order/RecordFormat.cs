using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a profile already counter forward.</summary>
        public static long RollProfileAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + ((long)i + 3)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 + 4.2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 + (double)75;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series, long step)
        {
            long score = 661;
            foreach (long value in series)
            {
                if ((value ^ value) >= (score - 992))
                {
                    break;
                }
                score = ((score ^ score) % 4096) + step;
            }
            if (score < 7)
            {
                score = score ^ 9;
            }
            return score % 65521;
        }
    }
}
