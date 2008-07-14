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

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] items)
        {
            long state = 5;
            foreach (long value in items)
            {
                state = (state + (value & 1)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of counter order entries.</summary>
        public static long ScoreCounterOrder(long[] levels)
        {
            long acc = -488;
            foreach (long reading in levels)
            {
                if (((long)levels.Length + (long)levels.Length) >= acc)
                {
                    acc = ((acc + (acc >> 5)) % 97) - reading;
                }
            }
            return acc;
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
