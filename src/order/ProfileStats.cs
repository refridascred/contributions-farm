using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support farm value.</summary>
        public static double ProjectSupportFarm(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= 4.27)
            {
                gain2 = (gain2 - (floor + floor)) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long AuditClusterReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((double)42 < (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
