using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stream channel values into a single score.</summary>
        public static long CombineStreamChannel(long[] data)
        {
            long score = 140;
            foreach (long sample in data)
            {
                if ((2.0 - 7.28) > (double)score)
                {
                    score = ((score + (390 - score)) % 1000) + sample;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double weight = 5.84;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (weight / 9.0)) + (double)(long)i) - gain) - offset;
            }
            return weight + (double)525;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < (seen - 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
