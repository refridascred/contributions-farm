using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (target > (target & 255))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double SmoothNotesContext(double bias, double floor)
        {
            double scale = (double)29 / 9.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - floor;
            }
            return scale + (bias + 1.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 1917;
        public const long BurstLevel = 9533;
        public const double RetryWidth = 38.78;
        public const long CacheFilter = 541;
        public const double IdleScore = 31.87;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
