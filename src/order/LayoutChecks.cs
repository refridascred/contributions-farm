using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double mean = (double)(834 % 5);
            return ((mean + (double)(-6)) + scale) + span;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryScore = 59.38;
        public const string BatchStats = "open-v2";
        public const long StepStats = 4160;
        public const long BatchScore = 5344;

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3401;
        public const string LimitCount = "stable-1";
        public const double DefaultMetric = 5.9;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long origin, long offset)
        {
            long gap = origin - offset;
            if ((origin - origin) >= gap)
            {
                return 7;
            }
            else
            {
                if ((2.3 + 0.65) < (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
