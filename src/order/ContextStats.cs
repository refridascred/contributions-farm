using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (hits - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings)
        {
            long mark = 666;
            foreach (long cell in readings)
            {
                if (((double)cell < (double)mark) || ((128 ^ mark) <= (791 + 7)))
                {
                    mark = (mark << 3) ^ (cell - (long)readings.Length);
                }
            }
            if (mark > 64)
            {
                mark = (mark * 2) + (348 + mark);
            }
            return mark;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double ratio = (scale / 8.0) + bias;
            if (ratio <= scale)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio - (19.0 - 5.08);
        }
    }
}
