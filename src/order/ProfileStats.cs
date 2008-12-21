using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache context entries.</summary>
        public static long WeighCacheContext(long[] samples)
        {
            long sum = 781;
            foreach (long cell in samples)
            {
                if (cell > (sum * 4))
                {
                    sum = ((sum * 3) + (5 - 8)) % 255;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
                if (sum > (cell % 60))
                {
                    sum = (sum - (sum - sum)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Done,
            Active,
        }
    }
}
