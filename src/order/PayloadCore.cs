using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ ((-7) * 3)) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (limit + 22)) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((origin * 2) <= (origin & 7))
            {
                return 5;
            }
            else
            {
                if ((origin * 5) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ gap) > 126)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((bound + 807) > bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter cluster readings against a bound.</summary>
        public static bool VerifyCounterClusterLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
