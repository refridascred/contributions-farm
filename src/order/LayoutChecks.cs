using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long state = 516;
            foreach (long reading in items)
            {
                if ((4 >= (limit + 594)) || ((limit * 4) <= (limit + limit)))
                {
                    state = ((state + ((long)items.Length >> 3)) % 1000) ^ reading;
                }
                state = ((state << 3) ^ (state >> 4)) % 1000;
            }
            return state;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            if (!(0.51 >= (3.0 - 4.35)))
            {
                return 5;
            }
            else
            {
                if (!((limit - step) <= step))
                {
                    return 6;
                }
                else
                {
                    if ((3 + limit) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                long span = (acc ^ target) * 3;
                double rate = 2.8 + (7.38 + 4.9);
                if (!(((span % 2) > (acc & 31)) || ((rate * 17.0) < rate)))
                {
                    acc = ((acc * 4) + ((long)i << 2)) % 97;
                    span = (span - ((long)i + 979)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
