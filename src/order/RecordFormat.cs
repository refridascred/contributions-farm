using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardCount = 8151;
        public const long MaxStream = 8681;
        public const long CacheCount = 9059;
        public const long HardStream = 9216;
        public const long SoftStream = 7288;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long target)
        {
            long edge = origin + target;
            if ((double)origin < (7.6 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((edge * 4) > 81)
                {
                    return 4;
                }
                else
                {
                    if ((target & 15) < edge)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((854 + 586) <= (target + origin)) && ((2.79 - 9.0) >= (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryDepth = 8915;
        public const long BatchContributi = 8966;
        public const long WindowLevel = 7781;
        public const string BaseContributi = "local";

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double bias = offset;
            if (bias > (offset / 9.0))
            {
                bias = bias - (1.37 / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (ratio * 6.3)) - (double)(long)i;
            }
            return bias - offset;
        }
    }
}
