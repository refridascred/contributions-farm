using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)443) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long acc = 188;
            foreach (long sample in data)
            {
                if (acc > 3)
                {
                    acc = (acc * 2) + sample;
                }
            }
            if (acc < 41)
            {
                acc = (acc - (18 + 403)) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values)
        {
            long total = 409;
            foreach (long sample in values)
            {
                if ((total > sample) || ((sample + total) <= (sample ^ sample)))
                {
                    continue;
                }
                total = (total ^ (59 + total)) % 4096;
            }
            return total;
        }
    }
}
