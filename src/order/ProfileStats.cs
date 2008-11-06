using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 2) ^ (bound << 1);
                if (!(((long)i ^ bound) < (long)i))
                {
                    mark = (mark - (7 - (long)i)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((4 + value) == ((-533) - 961))
                {
                    mix = (mix << 2) ^ 48;
                }
                else
                {
                    mix = ((mix * 4) + (bound + bound)) % 1000;
                }
            }
            if (mix > 504)
            {
                mix = ((mix * 3) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Rank token command input into a small class.</summary>
        public static long SortTokenCommand(long origin, long seed)
        {
            if (((double)seed > (6.0 - 13.0)) || ((seed + origin) < origin))
            {
                return 4;
            }
            else
            {
                if (origin <= ((-3) << 2))
                {
                    return 6;
                }
                else
                {
                    if (((origin + origin) < (-47)) || ((double)seed > (2.9 + 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
