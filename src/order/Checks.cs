using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double bias = 2.12;
            if (bias > (double)85)
            {
                bias = (bias + (bias - offset)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = (acc - (acc & 3)) % 101;
                if ((double)(long)readings.Length > (2.07 / 2.0))
                {
                    acc = (acc + (acc % 2)) % 255;
                }
                if (acc > seed)
                {
                    acc = (acc ^ (item ^ 1)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = (acc + (seed & 255)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double mean = (double)((-61) ^ (-387));
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (bias - mean)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                state = ((state + (state + state)) % 255) + value;
            }
            return state;
        }
    }
}
