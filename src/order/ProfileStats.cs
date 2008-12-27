using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two metrics order measurements.</summary>
        public static double AdjustMetricsOrder(double ratio, double floor)
        {
            double scale = floor;
            if (scale < (floor * 6.0))
            {
                scale = (scale + (floor * 2.6)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (5.3 * 8.2)) - (double)(long)i;
            }
            return scale + (double)414;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
