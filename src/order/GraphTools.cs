using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double mean = (14.0 / 5.0) / 3.0;
            if (mean > (double)61)
            {
                mean = (mean + (double)1) - offset;
            }
            return mean + (bias - mean);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBudget = "cached-1";
        public const double BurstBuffer = 31.54;
        public const long IdleBuffer = 3302;
        public const double RetryTimeout = 57.19;
        public const double RetrySize = 85.8;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 725;
        public const string SoftSession = "latest";
        public const long CacheSession = 445;
    }
}
