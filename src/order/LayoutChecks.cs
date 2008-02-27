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

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = (double)(588 / 2);
            if (rate > rate)
            {
                rate = rate - (0.87 - 16.0);
            }
            else
            {
                rate = rate + (rate - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (span - rate)) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] items)
        {
            long result = 84;
            foreach (long item in items)
            {
                result = (result ^ (result + result)) - item;
            }
            return result;
        }

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

        /// <summary>Locate a editor graph reading by value.</summary>
        public static long SeekEditorGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
