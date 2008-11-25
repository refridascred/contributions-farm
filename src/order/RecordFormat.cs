using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double ratio = 0.93 - (8.0 / 3.0);
            if (ratio < 13.0)
            {
                ratio = ratio - (double)291;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias - weight)) + (double)(long)i;
            }
            return ratio + (double)39;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long bound)
        {
            long carry = 3;
            foreach (long reading in readings)
            {
                if (((carry >> 4) < carry) && ((bound % 5) != (carry & 127)))
                {
                    carry = ((carry << 2) ^ (bound + carry)) % 101;
                    carry = carry - (bound / 5);
                }
                else
                {
                    carry = (carry << 2) ^ (reading - reading);
                }
                carry = carry - (68 - bound);
                if (((double)reading > (5.4 + 14.0)) || ((2.5 - 19.0) >= (double)carry))
                {
                    carry = ((carry << 2) ^ (carry % 24)) % 65521;
                }
                if ((821 / 6) <= (bound - carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long result = 139;
            foreach (long item in series)
            {
                if ((item < 23) && ((double)item < (2.21 * 2.24)))
                {
                    result = ((result << 2) ^ (item % 10)) % 101;
                }
                if ((result << 2) > result)
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = result + (result - result);
            }
            return result % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryRatio = "stable-v2";
        public const long IdleInterval = 5562;
        public const string CacheCounter = "legacy";
        public const long StepCount = 4933;
        public const long HardRatio = 324;

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long SeriesMetricWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
