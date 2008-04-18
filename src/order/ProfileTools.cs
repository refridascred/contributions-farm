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

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "latest";
        public const long BaseSupport = 6685;
        public const double HardFactor = 80.72;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if (((sum + sum) <= 549) && ((cell - sum) > (sum ^ cell)))
                {
                    sum = sum + (sum >> 1);
                }
            }
            if (sum > 115)
            {
                sum = (sum + sum) % 65521;
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
