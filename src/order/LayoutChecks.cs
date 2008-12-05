using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data)
        {
            long carry = 875;
            foreach (long cell in data)
            {
                if ((cell & 31) <= (cell + cell))
                {
                    carry = (carry << 3) ^ (carry ^ carry);
                }
            }
            if (carry < 2)
            {
                carry = (carry - (carry & 127)) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (bias * 9.67)) + (double)(long)i) - span;
            }
            return drift - (double)0;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                if ((reading + reading) < (8 % 3))
                {
                    result = ((result * 5) + (reading + result)) % 1000;
                }
                if ((4.3 / 6.0) <= (double)(long)readings.Length)
                {
                    break;
                }
            }
            if (result < 46)
            {
                result = (result ^ (662 >> 3)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count > 6.0)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 76.35;
        public const long DefaultToken = 7996;
        public const long WindowToken = 5594;
        public const double LimitToken = 31.63;
        public const double MaxWidth = 69.31;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + bound) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
