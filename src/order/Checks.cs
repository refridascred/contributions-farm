using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchCount = "strict-v2";
        public const string RetryFactor = "cached-1";
        public const long SoftProfile = 1309;

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double weight = 5.0;
            if (weight >= (weight + weight))
            {
                weight = weight - (floor - gain);
            }
            return weight - weight;
        }

        /// <summary>Adjust a context buffer reading.</summary>
        public static double ScaleContextBuffer(double bias, double offset)
        {
            double bias2 = (offset + offset) / 6.0;
            if (bias2 > (bias2 - 6.2))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (2.0 + bias);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items)
        {
            long mark = 713;
            foreach (long entry in items)
            {
                mark = mark - (entry - mark);
            }
            return mark % 4096;
        }
    }
}
