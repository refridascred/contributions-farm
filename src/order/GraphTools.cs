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

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                sum = (((sum ^ sum) % 101) ^ sample) + target;
            }
            if (sum < 11)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
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
