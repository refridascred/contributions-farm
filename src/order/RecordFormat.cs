using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 47.92;
        public const long BaseSpan = 1071;
        public const long BurstInterval = 8730;
        public const long WindowQueue = 4734;
        public const string LimitQueue = "latest-v2";

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultCount = 965;
        public const double BatchInterval = 12.22;
        public const long BurstFactor = 3020;
        public const double SoftBudget = 2.09;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long origin)
        {
            long prev = limit + origin;
            if ((prev >= (limit + 736)) && ((origin / 2) <= (origin ^ 90)))
            {
                return 0;
            }
            else
            {
                if ((double)limit > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((prev + prev) >= (8 + prev))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 4) != (prev & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
