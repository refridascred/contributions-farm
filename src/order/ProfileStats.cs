using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((9.26 + 1.4) <= (double)tally))
                {
                    tally = ((tally + 2) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((829 <= (count & 15)) && ((5.0 - 4.7) < (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((8 << 1) <= (seen + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
