using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double bias = scale;
            if (bias <= (17.0 * 8.7))
            {
                bias = bias + (scale + span);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (5.0 - 8.04)) + (double)(long)i;
            }
            return bias - 2.5;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Synced,
            Done,
        }
    }
}
