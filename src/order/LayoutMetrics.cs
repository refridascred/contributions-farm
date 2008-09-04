using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of githubfarm already readings.</summary>
        public static long CombineGithubfarmAlready(long[] data)
        {
            long carry = 10;
            foreach (long reading in data)
            {
                if ((double)carry >= 7.63)
                {
                    carry = (((carry << 3) ^ (carry ^ carry)) % 4096) - reading;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 255;
                }
            }
            if (carry > 0)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value == (8.0 - 2.8))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
