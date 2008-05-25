using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= 8.8)
                {
                    hits = ((hits + 3) ^ entry) + bound;
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long origin)
        {
            if ((2 >= bound) && (49 >= bound))
            {
                return 1;
            }
            else
            {
                if (!((origin % 64) < (bound - origin)))
                {
                    return 6;
                }
                else
                {
                    if (((origin + origin) < (bound - 50)) || ((6.6 - 0.4) >= (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin == (9.0 * 8.1))
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
        }
    }
}
