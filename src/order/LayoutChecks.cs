using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2344;
        public const string MinWindow = "open";
        public const long RetryWindow = 8531;
        public const long WindowRatio = 8382;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 66.75;
        public const long BaseOrder = 7656;
        public const double IdleOrder = 78.63;
        public const long StepCount = 9518;
        public const long SoftOrder = 8648;

        /// <summary>Combine filter metric values into a single score.</summary>
        public static long DigestFilterMetric(long[] readings, long floor)
        {
            long mix = 647;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ (reading % 16)) % 1000) - floor;
            }
            if (mix < 91)
            {
                mix = (mix + (mix >> 5)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = 613;
            foreach (long datum in items)
            {
                if ((state & 15) != (state + datum))
                {
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    state = ((state - (state + datum)) % 101) + (long)i;
                }
                if ((datum & 31) < (state % 60))
                {
                    state = (state - (2 - datum)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
