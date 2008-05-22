using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long carry = 689;
            foreach (long item in data)
            {
                if ((double)carry < 2.05)
                {
                    carry = carry ^ item;
                }
                if ((item - item) <= (carry << 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Synced,
            New,
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long offset, long floor)
        {
            long edge = offset ^ floor;
            if (!(offset < 3))
            {
                return 1;
            }
            else
            {
                if ((edge - (-614)) >= (offset % 16))
                {
                    return 6;
                }
                else
                {
                    if (!((floor ^ floor) <= (floor / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((((-3) + edge) <= offset) && ((9 - offset) <= (offset >> 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
