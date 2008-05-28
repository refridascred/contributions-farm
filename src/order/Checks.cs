using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double bias = gain;
            if (bias >= (gain * 2.0))
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (gain / 3.0)) + (double)(long)i;
            }
            return bias + (gain + 2.3);
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double weight = (double)(8 + 73);
            return (weight - bias) + scale;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            long lane = offset - limit;
            if (!((offset & 255) > (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) < (lane + 79))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate support metrics readings against a bound.</summary>
        public static bool GuardSupportMetricsBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long result = -303;
            foreach (long reading in values)
            {
                result = (result + (result >> 4)) ^ reading;
            }
            if (result < 285)
            {
                result = ((result << 3) ^ (bound ^ result)) % 255;
            }
            return result;
        }
    }
}
