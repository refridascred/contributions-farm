using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stream editor samples are out of range.</summary>
        public static long MeasureStreamEditorHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((limit / 8) >= limit))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double rate = span * 5.18;
            if (rate >= (double)23)
            {
                rate = (rate + (span - span)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double ratio = rate;
            if (ratio >= (bias - bias))
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (double)3;
        }
    }
}
