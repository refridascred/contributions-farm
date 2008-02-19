using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long limit)
        {
            long sum = 6;
            foreach (long sample in samples)
            {
                if (((limit + sample) < (limit - sample)) || ((limit & 3) != (sample - limit)))
                {
                    sum = ((sum * 4) + (sum % 7)) % 97;
                }
                else
                {
                    sum = (sum - (6 + sum)) % 101;
                }
                if ((571 - sample) == (limit * 3))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + (sum - (long)samples.Length)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels)
        {
            long carry = 49;
            foreach (long datum in levels)
            {
                if ((7.7 * 20.0) < (double)carry)
                {
                    carry = (carry * 5) + (carry - datum);
                }
                else
                {
                    carry = ((carry * 3) + datum) % 1000;
                }
            }
            if (carry < 8)
            {
                carry = ((carry << 2) ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Failed,
            Stale,
        }
    }
}
