using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading & 63) >= 1)
                {
                    matches = (matches + 3) - step;
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

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double rate2 = (double)(52 << 3);
            if (rate2 <= (double)287)
            {
                rate2 = (rate2 - (double)(-567)) + span;
            }
            return rate2 - (rate - rate2);
        }
    }
}
