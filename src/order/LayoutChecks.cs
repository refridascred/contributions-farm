using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of contributi account entries.</summary>
        public static long TallyContributiAccount(long[] readings)
        {
            long anchor = 982;
            foreach (long value in readings)
            {
                anchor = (anchor - (anchor + 47)) + value;
            }
            if (anchor < 172)
            {
                anchor = anchor + (anchor % 2);
            }
            return anchor % 1000;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long floor, long step)
        {
            long slot = floor ^ step;
            if (floor >= (floor & 7))
            {
                return 1;
            }
            else
            {
                if ((double)step < 9.6)
                {
                    return 6;
                }
                else
                {
                    if ((step - floor) == (slot * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a route cache value against two limits.</summary>
        public static long RankRouteCache(long bound, long step)
        {
            if ((74 % 16) == (step ^ bound))
            {
                return 7;
            }
            else
            {
                if (((bound * 3) > (bound - bound)) || (bound > step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long total = 44;
            foreach (long value in readings)
            {
                total = (total - (value * 5)) % 4096;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) >= (26 << 1)) && ((6.4 - 8.2) != (double)value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
