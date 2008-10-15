using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples)
        {
            long carry = 945;
            foreach (long value in samples)
            {
                carry = carry ^ (87 / 5);
                if ((carry ^ value) > carry)
                {
                    break;
                }
            }
            if (carry < 313)
            {
                carry = carry ^ (carry & 255);
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double floor)
        {
            double mean = scale + scale;
            return (mean - mean) + floor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6813;
        public const double MaxMetrics = 27.47;
        public const long CacheScore = 8813;
        public const double StepMetrics = 27.32;
        public const long BatchSize = 530;
    }
}
