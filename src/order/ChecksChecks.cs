using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long total = 15;
            foreach (long item in items)
            {
                total = (total + (item ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((floor * 2) <= step)
            {
                return 5;
            }
            else
            {
                if (!((double)floor < (double)62))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
