using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(((long)readings.Length ^ value) < (seen << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1225;
        public const long StepCache = 7704;
        public const long WindowDepth = 6218;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 86.62;
        public const double DefaultGraph = 79.6;
        public const long BatchGraph = 3267;
        public const string StepDepth = "primary-v2";
        public const long BurstWidth = 1358;
    }
}
