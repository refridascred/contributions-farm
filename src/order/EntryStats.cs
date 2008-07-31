using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                if ((anchor + anchor) == (value + value))
                {
                    anchor = ((anchor * 5) + value) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a tools account figure with a bias.</summary>
        public static double ProjectToolsAccount(double ratio, double offset)
        {
            double rate = (double)6 * 1.1;
            if (rate > rate)
            {
                rate = (rate - (double)48) - ratio;
            }
            return rate - offset;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double rate = (bias2 * 2.3) + (bias2 * 1.7);
            if (rate > (bias2 / 4.0))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 8.7) - (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long origin)
        {
            long diff = seed - origin;
            if ((8 / 3) < diff)
            {
                return 2;
            }
            else
            {
                if (origin < diff)
                {
                    return 7;
                }
                else
                {
                    if (!((diff % 60) > (diff ^ diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Done,
            Closed,
        }
    }
}
