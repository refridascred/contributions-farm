using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 3) ^ ((long)i & 7);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool GuardMetricBatchesBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Synced,
            Pending,
            Active,
        }
    }
}
