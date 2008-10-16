using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long limit)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                if ((cell + 603) >= (limit % 12))
                {
                    total = total + (cell ^ cell);
                }
                else
                {
                    total = (total << 2) ^ (-679);
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            New,
            Done,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((4 * 3) != (tally + value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
