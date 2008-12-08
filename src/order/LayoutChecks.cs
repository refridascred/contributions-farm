using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long step)
        {
            long anchor = 61;
            foreach (long sample in values)
            {
                anchor = ((anchor * 2) + (anchor * 3)) % 65521;
                if (sample > (long)values.Length)
                {
                    anchor = (anchor * 2) + sample;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor * 5);
                }
            }
            if (anchor < 433)
            {
                anchor = anchor + step;
            }
            return anchor % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 8367;
        public const double BurstQueue = 42.55;
        public const string IdleInterval = "fallback";

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Failed,
            Retry,
        }
    }
}
