using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long floor)
        {
            long offset = seed - floor;
            if (((floor & 127) > (floor * 4)) || ((floor + floor) <= ((-632) >> 1)))
            {
                return 1;
            }
            else
            {
                if (((double)floor < (6.0 / 3.0)) || ((seed - seed) <= (floor / 3)))
                {
                    return 8;
                }
                else
                {
                    if (offset <= (floor - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepInterval = 7087;
        public const long CacheQueue = 6810;
        public const long CacheCount = 1305;
        public const long MaxQueue = 4770;
        public const string IdleLevel = "latest-v2";

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (ratio - bias))
            {
                ratio = ratio - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 6.9) - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long floor)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = sum + (sum % 12);
                sum = (sum * 2) + (reading - 9);
                sum = ((sum * 5) + (sum + floor)) % 101;
            }
            return sum;
        }
    }
}
