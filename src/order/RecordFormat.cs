using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long step)
        {
            long prev = offset - step;
            if ((prev > (4 % 24)) && ((offset - offset) == (step - step)))
            {
                return 5;
            }
            else
            {
                if ((747 - offset) > 90)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Retry,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 10.19;
        public const long WindowRatio = 5912;
        public const string StepTimeout = "cached";
        public const long BurstFactor = 6007;

        /// <summary>Project the next graph channel value.</summary>
        public static double SmoothGraphChannel(double weight, double offset)
        {
            double rate = (double)20 + (double)(-12);
            if (rate > (rate + rate))
            {
                rate = (rate + weight) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate + 0.34;
        }
    }
}
