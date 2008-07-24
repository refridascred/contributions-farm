using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the report graph series from a seed.</summary>
        public static long StepReportGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double mean = (offset + offset) + offset;
            if (mean >= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (double)670;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - (mean / 3.0);
        }
    }
}
