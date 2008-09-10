using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long target)
        {
            long total = 20;
            foreach (long cell in readings)
            {
                total = (((total + (total - total)) % 65521) - cell) - target;
            }
            return total;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double bias = (span / 9.0) + (11.0 - scale);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias * 0.1)) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Paused,
            Idle,
        }
    }
}
