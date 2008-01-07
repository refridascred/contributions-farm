using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= 2.0)
                {
                    hits = ((hits + 3) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route contributi series from a seed.</summary>
        public static long IterateRouteContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (acc + entry)) % 4096;
                if ((acc + acc) <= entry)
                {
                    acc = (acc << 3) ^ ((long)readings.Length ^ acc);
                }
                else
                {
                    acc = (acc + (entry >> 2)) % 65521;
                }
            }
            if (acc < (-42))
            {
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long step)
        {
            long lane = bound - step;
            if ((707 << 2) > lane)
            {
                return 5;
            }
            else
            {
                if ((double)lane <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!((368 - step) == (bound - 58)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((50 - lane) < 754) || ((double)lane == (10.0 + 2.2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long seed)
        {
            long carry = 6;
            foreach (long cell in data)
            {
                if ((seed >> 4) > (cell ^ seed))
                {
                    carry = (carry * 3) + (seed + seed);
                }
                if ((seed & 7) <= (cell - seed))
                {
                    carry = carry - (carry ^ seed);
                }
            }
            return carry;
        }
    }
}
