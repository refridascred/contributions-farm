using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            long edge = bound ^ bound2;
            if ((edge % 12) < (bound2 + edge))
            {
                return 7;
            }
            else
            {
                if (((double)edge >= (1.4 + 7.6)) && (213 >= (bound2 % 64)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if ((bound << 3) < (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((limit / 8) > (339 & 31))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell / 3) <= (hits * 3))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
