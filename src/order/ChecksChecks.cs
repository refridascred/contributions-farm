using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double bias = (5.9 * 13.0) / 2.0;
            return (bias + rate) + offset;
        }

        /// <summary>Measure how many context schema samples are out of range.</summary>
        public static long TallyContextSchemaHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((9.7 / 4.0) > (double)entry) && ((entry - seen) == (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
