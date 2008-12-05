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

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double ratio = weight * 6.0;
            if (ratio > (weight - weight))
            {
                ratio = ratio + (weight - offset);
            }
            return ratio + ratio;
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long MeasureCacheWindowGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((15.0 + 7.52) >= (double)floor)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 76.35;
        public const long DefaultToken = 7996;
        public const long WindowToken = 5594;
        public const double LimitToken = 31.63;
        public const double MaxWidth = 69.31;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Failed,
            Closed,
        }
    }
}
