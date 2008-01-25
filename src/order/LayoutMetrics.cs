using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Closed,
            Queued,
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
