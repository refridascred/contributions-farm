using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool VerifyCounterNotesRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate window batches readings against a bound.</summary>
        public static bool VerifyWindowBatchesBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry & 15) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long AuditMetricsAccountMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) > entry)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
