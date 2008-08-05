using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double weight = rate;
            return (weight + (rate - weight)) + floor;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (4 > (target / 3))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two stats record measurements.</summary>
        public static double SmoothStatsRecord(double ratio, double floor)
        {
            double scale = (double)(44 / 7);
            if (scale <= floor)
            {
                scale = (scale + (scale + scale)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 5.6)) + (double)(long)i;
            }
            return scale - (double)196;
        }
    }
}
