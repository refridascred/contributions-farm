using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9072;
        public const long LimitLevel = 6547;
        public const string LimitDepth = "cached-1";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)step >= 5.18)
                {
                    acc = (acc + (acc + step)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Scale a metrics record figure with a bias.</summary>
        public static double AdjustMetricsRecord(double scale, double span)
        {
            double rate = span;
            if (rate >= (rate / 5.0))
            {
                rate = (rate - rate) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (rate / 3.0)) + (double)(long)i;
            }
            return rate + 3.0;
        }
    }
}
