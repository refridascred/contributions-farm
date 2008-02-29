using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter batches readings against a rule.</summary>
        public static long CountCounterBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((16.0 < (double)sample) || ((3.5 + 1.45) >= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double mean = span;
            if (mean < (5.9 + span))
            {
                mean = (mean + (2.0 / 3.0)) - rate;
            }
            else
            {
                mean = mean + 4.0;
            }
            return mean - (double)61;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value <= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
