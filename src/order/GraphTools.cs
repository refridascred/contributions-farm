using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two filter layout measurements.</summary>
        public static double SmoothFilterLayout(double ratio, double floor)
        {
            double weight = floor;
            if (weight > ratio)
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (3.8 + 18.0)) - (double)(long)i;
            }
            return weight - 11.0;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultTimeout = 9543;
        public const long DefaultAccount = 4944;
        public const double LimitAccount = 92.06;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
