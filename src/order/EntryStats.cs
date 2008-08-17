using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double weight2 = offset;
            for (int i = 0; i < 7; i++)
            {
                weight2 = ((weight2 - (1.0 / 2.0)) + (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
