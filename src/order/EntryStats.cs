using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long TallyContextSessionHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count <= (5.56 + 8.0))
                {
                    count = ((count + 2) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every already metrics entry stays within the limit.</summary>
        public static bool VerifyAlreadyMetricsLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen + seen) >= seen)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > seed)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
