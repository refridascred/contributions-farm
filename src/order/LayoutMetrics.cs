using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long total = 270;
            foreach (long value in readings)
            {
                total = (total ^ (value >> 2)) % 255;
                if ((((long)readings.Length + value) >= (value + 43)) || ((9 + 52) == (total >> 4)))
                {
                    total = (total ^ (value % 5)) % 4096;
                }
                if ((value + value) < (value + total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of already cache entries.</summary>
        public static long ScoreAlreadyCache(long[] items)
        {
            long sum = -9;
            foreach (long entry in items)
            {
                sum = (sum ^ 524) - entry;
            }
            if (sum > 28)
            {
                sum = (sum - (sum + sum)) % 97;
            }
            return sum;
        }
    }
}
