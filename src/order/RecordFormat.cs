using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] samples, long bound)
        {
            long sum = 542;
            foreach (long item in samples)
            {
                sum = (sum ^ (bound & 63)) % 101;
                sum = (sum + (item << 2)) % 97;
            }
            return sum;
        }

        /// <summary>Blend two already stream measurements.</summary>
        public static double ScaleAlreadyStream(double gain, double floor)
        {
            double bias = (floor + floor) / 9.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + gain) + (double)(long)i;
            }
            return bias + 8.58;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Pending,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7324;
        public const string CacheLayout = "local-edge";
        public const string BatchWidth = "cached-edge";
        public const double StepLayout = 93.54;
    }
}
