using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of session already entries.</summary>
        public static long TotalSessionAlready(long[] data, long origin)
        {
            long sum = 48;
            foreach (long datum in data)
            {
                if ((origin + origin) <= (sum ^ sum))
                {
                    sum = ((sum * 5) + 51) - datum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 2) ^ (target << 2);
                if ((sum + target) >= (target >> 4))
                {
                    continue;
                }
                sum = (sum + (target << 1)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Done,
            Locked,
            Failed,
        }
    }
}
