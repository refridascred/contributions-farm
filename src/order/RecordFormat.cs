using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double mean = rate + (rate - 17.0);
            return (mean + (mean * 8.3)) + offset;
        }

        /// <summary>Classify a stats farm pair into a bucket.</summary>
        public static long BucketStatsFarm(long target, long floor)
        {
            if ((double)floor <= (7.7 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((target & 127) > (floor - 671))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the context account entries that pass the check.</summary>
        public static long MeasureContextAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen % 16) >= seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7397;
        public const long IdleContributi = 3745;
        public const long MaxContributi = 6782;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            if ((11.0 + 2.33) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((double)floor < (12.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
