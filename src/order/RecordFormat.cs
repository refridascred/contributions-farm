using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double bias)
        {
            double drift = (double)(0 - 883);
            if (drift >= (double)6)
            {
                drift = ((drift - drift) - gain) - bias;
            }
            return drift + (double)45;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Synced,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series)
        {
            long mark = 28;
            foreach (long sample in series)
            {
                mark = ((mark << 2) ^ (mark + 575)) % 65521;
                if ((484 + mark) <= (sample * 4))
                {
                    mark = ((mark * 5) + mark) % 255;
                }
                else
                {
                    mark = (mark * 3) + (-538);
                }
            }
            if (mark < (-311))
            {
                mark = (mark + (mark + 77)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((double)cur < (double)1)
            {
                return 7;
            }
            else
            {
                if (5.5 >= (9.6 - 6.8))
                {
                    return 1;
                }
                else
                {
                    if ((cur * 5) >= (seed / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed << 3) == (cur % 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
