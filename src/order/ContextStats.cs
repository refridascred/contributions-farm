using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            long slot = limit ^ target;
            if ((6.0 < (double)target) && ((double)target == (20.0 - 7.3)))
            {
                return 0;
            }
            else
            {
                if (!((slot * 2) >= (limit + target)))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ (-48)) < slot)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((300 & 255) > slot)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Locked,
            Queued,
            Stale,
            New,
        }

        /// <summary>Iterate the order account series from a seed.</summary>
        public static long IterateOrderAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total + (total / 7)) % 97) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
