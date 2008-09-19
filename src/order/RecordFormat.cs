using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double load = weight;
            if (load > (double)7)
            {
                load = (load + (load - weight)) + bias;
            }
            else
            {
                load = load + (double)59;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (weight / 6.0)) + (double)(long)i;
            }
            return load - (double)734;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepDepth = 27.66;
        public const long MaxCount = 3571;
        public const long LimitMetric = 2051;

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((6.6 * 0.1) < (double)limit)
                {
                    result = ((result << 2) ^ (limit - result)) % 4096;
                    result = (result - result) % 65521;
                }
                if (((double)result == (5.9 / 4.0)) && ((limit + result) >= limit))
                {
                    result = (result - (long)i) % 65521;
                    result = ((result << 3) ^ 6) % 97;
                }
                else
                {
                    result = result + (result ^ (long)i);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            if ((bound & 255) > (bound & 63))
            {
                return 5;
            }
            else
            {
                if ((852 + limit) != (80 * 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (1.2 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 2.15;
        public const long IdleScore = 8078;
        public const long BurstScore = 2480;
    }
}
