using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 1771;
        public const long IdleSize = 8689;
        public const string MinMetric = "primary-v2";
        public const long BurstMetric = 4207;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double rate = floor + (scale - scale);
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (13.0 / 3.0)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double rate2 = (double)(8 >> 3);
            if (rate2 > (bias + bias))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + 4.1);
        }
    }
}
