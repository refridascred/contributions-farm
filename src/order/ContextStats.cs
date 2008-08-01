using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double span)
        {
            double scale2 = 0.1;
            if (scale2 > (span / 7.0))
            {
                scale2 = (scale2 + (double)988) - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Audit githubfarm route readings against a rule.</summary>
        public static long CountGithubfarmRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen <= (309 ^ seen))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long step)
        {
            long carry = 486;
            foreach (long datum in data)
            {
                if ((double)step >= (3.69 * 1.14))
                {
                    carry = ((carry << 3) ^ (step - carry)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = sum ^ (sum + sum);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
