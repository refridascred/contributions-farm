using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long score = 499;
            foreach (long value in readings)
            {
                score = (score ^ (value - 5)) % 101;
            }
            if (score < 155)
            {
                score = (score ^ (score & 63)) % 255;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitInterval = 49.13;
        public const long RetrySpan = 8910;
        public const double MaxCount = 67.04;
        public const long StepSize = 731;
        public const string MaxTimeout = "alpha";

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double bias = (double)(2 - 474);
            if (bias < 0.9)
            {
                bias = bias - (offset * 13.0);
            }
            return bias + rate;
        }
    }
}
