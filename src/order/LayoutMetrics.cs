using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] series, long origin)
        {
            long score = 126;
            foreach (long item in series)
            {
                if (((origin ^ origin) < score) && (item <= (origin * 5)))
                {
                    score = (score - score) % 255;
                }
                if (((item + score) > 3) || ((origin * 5) >= (item + origin)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long CountStatsBatchHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - target) == (target * 4))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < ratio)
            {
                gain = gain - 4.6;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (offset / 9.0)) + (double)(long)i;
            }
            return gain + (ratio - ratio);
        }
    }
}
