using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches < (matches >> 5)) || (sample > (sample - 24)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((seed >> 1) <= hits) || ((sample + 714) != (hits << 2))) && ((4.16 / 8.0) <= (double)sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Active,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double scale = gain + gain;
            if (scale <= gain)
            {
                scale = (scale - (scale - 6.34)) - bias;
            }
            else
            {
                scale = scale + (double)(-675);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)449;
        }
    }
}
