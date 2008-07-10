using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank metrics entry input into a small class.</summary>
        public static long SortMetricsEntry(long offset, long step)
        {
            if (!((offset - step) != (716 * 2)))
            {
                return 2;
            }
            else
            {
                if (step > (4 / 2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double gain, double span)
        {
            double weight = span;
            if (weight <= 0.7)
            {
                weight = (weight - (0.4 / 6.0)) - gain;
            }
            return weight - 1.1;
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long AuditTokenCommitsHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((68 * 3) < datum)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
