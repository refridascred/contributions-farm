using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + step) == (step * 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Grade a order session value against two limits.</summary>
        public static long ClassifyOrderSession(long floor, long seed)
        {
            if ((92 > seed) || ((floor << 1) >= ((-71) << 2)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed >= (5.3 * 11.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1852;
        public const string RetryRatio = "strict-edge";
        public const long SoftDepth = 4416;
        public const long LimitRatio = 5115;
        public const double RetrySchema = 30.84;

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double floor)
        {
            double ratio = floor + (floor / 3.0);
            return (ratio - (ratio * 8.0)) + gain;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
