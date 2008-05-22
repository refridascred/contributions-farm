using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < 2.81)
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset + weight)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((origin + origin) < (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
