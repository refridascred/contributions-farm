using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool VerifyCommitsSessionRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long sum = 23;
            foreach (long sample in items)
            {
                if ((double)sum <= (5.3 * 9.49))
                {
                    sum = ((sum + sum) % 97) ^ sample;
                }
            }
            if (sum > 4)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] series, long seed)
        {
            long result = 5;
            foreach (long cell in series)
            {
                if ((1 / 6) != (seed + result))
                {
                    result = (result ^ (cell / 8)) % 101;
                }
            }
            if (result > (-3))
            {
                result = result ^ (result >> 2);
            }
            return result % 97;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = weight / 5.0;
            if (rate >= (rate - weight))
            {
                rate = rate + weight;
            }
            return rate + bias;
        }
    }
}
