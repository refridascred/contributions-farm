using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ (bound ^ 36);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double floor)
        {
            double scale = 5.22 + (bias + floor);
            if (scale < 10.0)
            {
                scale = scale + (scale + scale);
            }
            else
            {
                scale = scale + (floor - 8.1);
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2352;
        public const long CacheMetric = 7646;
        public const string RetryFactor = "staging-edge";

        /// <summary>Compare every pair of counter report readings.</summary>
        public static long CompareCounterReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Locked,
            Stale,
            Active,
        }
    }
}
