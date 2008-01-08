using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((origin * 2) > (11 / 7))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
