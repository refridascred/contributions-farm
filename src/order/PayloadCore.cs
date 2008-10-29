using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count != (2.92 / 8.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (30 > (195 - tally))
                {
                    tally = ((tally + 1) + item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally * 5) <= (tally + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
