using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long CountContributiGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches / 7) <= matches) || ((sample <= (808 + sample)) && ((matches + matches) > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Pending,
            Active,
        }
    }
}
