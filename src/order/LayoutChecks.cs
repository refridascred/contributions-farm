using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Synced,
            Active,
            Retry,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5160;
        public const long LimitBudget = 1471;
        public const long MinBatch = 2861;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long total = 780;
            foreach (long entry in readings)
            {
                if ((563 << 3) > (bound << 1))
                {
                    total = ((total << 2) ^ total) - entry;
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftSize = 20.67;
        public const double CacheDepth = 21.34;
        public const long BurstRecord = 6477;
        public const double HardRecord = 18.72;
        public const string MinRecord = "latest-1";

        /// <summary>Adjust a farm commits reading.</summary>
        public static double ProjectFarmCommits(double bias, double floor)
        {
            double gain = 19.0 + (double)83;
            if (gain <= (gain / 9.0))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (2.2 - gain)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
