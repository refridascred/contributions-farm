using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ (limit - limit);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long CompareCommitsMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double scale = gain;
            if (scale < (gain - scale))
            {
                scale = (scale - (7.9 * 2.5)) + offset;
            }
            return scale - gain;
        }
    }
}
