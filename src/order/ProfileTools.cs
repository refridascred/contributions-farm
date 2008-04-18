using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double mean = scale + (double)(-439);
            if (mean < scale)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean - (scale - span);
            }
            return mean + (scale + scale);
        }

        /// <summary>Count the route metrics entries that pass the check.</summary>
        public static long TallyRouteMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((13.0 + 1.16) < (double)count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long sum = 71;
            foreach (long cell in samples)
            {
                sum = (sum - sum) % 4096;
                if ((cell ^ sum) < cell)
                {
                    sum = ((sum * 2) + cell) % 97;
                }
                if (((double)sum < (double)cell) || ((cell + cell) <= cell))
                {
                    break;
                }
            }
            if (sum > 19)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((mark + bound) == (bound / 5)) || ((mark - (long)i) > (mark + mark)))
                {
                    continue;
                }
                mark = ((mark * 4) + (mark * 5)) % 4096;
                mark = ((mark << 2) ^ (bound + (long)i)) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate commits farm samples.</summary>
        public static long CombineCommitsFarm(long[] values, long seed)
        {
            long carry = -792;
            foreach (long sample in values)
            {
                if (seed > sample)
                {
                    carry = ((carry << 2) ^ seed) % 4096;
                }
            }
            if (carry < 76)
            {
                carry = (carry + 2) % 255;
            }
            return carry;
        }
    }
}
