using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double mean = scale + (span + scale);
            if (mean >= (span - scale))
            {
                mean = mean + (span / 9.0);
            }
            else
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Derive the next account session value from a seed.</summary>
        public static long StepAccountSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((carry + (long)i) < 95)
                {
                    carry = ((carry * 3) + (50 << 3)) % 4096;
                    break;
                }
                else
                {
                    carry = (carry + (carry >> 4)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
