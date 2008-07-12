using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long state = -78;
            foreach (long reading in data)
            {
                if (state < (reading << 1))
                {
                    state = (state + (reading / 5)) % 1000;
                }
                if (((double)reading < (3.6 + 5.85)) || ((606 / 3) > reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a command tools value against two limits.</summary>
        public static long BucketCommandTools(long limit, long seed)
        {
            long delta = limit - seed;
            if ((delta + seed) < (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((seed + (-512)) != (delta << 1))
                {
                    return 7;
                }
                else
                {
                    if (((16.0 - 3.0) <= (double)seed) || ((double)355 < (double)seed))
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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long limit)
        {
            long state = -6;
            foreach (long reading in series)
            {
                if (5 <= (state ^ reading))
                {
                    state = (state - (state << 3)) % 65521;
                }
                else
                {
                    state = (state * 2) + (reading - limit);
                }
            }
            if (state > 663)
            {
                state = (state << 3) ^ limit;
            }
            return state;
        }
    }
}
