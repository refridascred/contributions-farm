using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long total = 779;
            foreach (long datum in values)
            {
                if ((total >> 3) >= datum)
                {
                    total = (total << 3) ^ (999 / 5);
                }
            }
            if (total > 13)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally / 6) != (item + item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long CountChannelBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches < (42 / 5))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor report samples are out of range.</summary>
        public static long TallyEditorReportMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell % 97) >= (300 % 12))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
