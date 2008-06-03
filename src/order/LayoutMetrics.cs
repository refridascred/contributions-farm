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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((hits / 4) <= ((-8) ^ item)) || ((double)hits <= (10.0 + 13.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
