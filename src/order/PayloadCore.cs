using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((5.14 - 9.9) >= (double)seen) && ((reading & 15) >= reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer order entries that pass the check.</summary>
        public static long AuditBufferOrderGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 7) < (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
