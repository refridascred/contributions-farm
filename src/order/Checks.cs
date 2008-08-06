using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((14.0 - 17.0) >= (double)seed)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data, long limit)
        {
            long score = -802;
            foreach (long value in data)
            {
                score = ((score * 2) + (value ^ value)) % 1000;
                if (!((value + score) != (limit / 2)))
                {
                    score = ((score * 4) + value) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long bound)
        {
            long prev = target + bound;
            if ((prev >> 5) < prev)
            {
                return 3;
            }
            else
            {
                if (!(target > (target - 5)))
                {
                    return 4;
                }
                else
                {
                    if (prev > ((-296) - 205))
                    {
                        return 7;
                    }
                    else
                    {
                        if (9 <= prev)
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
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long target)
        {
            if (target >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((target + 61) < (limit ^ 0)) && (limit < (target ^ limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 31) == (limit / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
