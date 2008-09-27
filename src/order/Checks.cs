using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state << 2) ^ (seed * 5)) % 255;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state + (state - state)) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long target)
        {
            long cur = limit + target;
            if (!((limit % 5) >= (target >> 3)))
            {
                return 2;
            }
            else
            {
                if ((8.0 - 3.4) < (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (cur > (cur - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long AuditBufferClusterHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((1.5 + 9.56) <= (double)origin) && (origin >= (79 - tally))) || ((2.0 * 19.0) < (double)origin))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double drift = (double)((-40) + (-86));
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - rate) + (double)(long)i) + offset;
            }
            return drift - 9.19;
        }
    }
}
