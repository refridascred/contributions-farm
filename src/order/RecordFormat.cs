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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (5.3 >= (double)count)
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
