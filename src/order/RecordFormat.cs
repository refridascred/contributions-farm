using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6917;
        public const double WindowSize = 4.81;
        public const double LimitCluster = 40.63;
        public const long IdleCluster = 7033;
        public const long CacheInterval = 6811;

        /// <summary>Audit notes payload readings against a rule.</summary>
        public static long CountNotesPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((datum % 2) != (datum - datum)) || ((double)count >= 0.8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleWidth = "fallback";
        public const double StepGithubfarm = 62.94;
        public const double MinWidth = 52.25;
    }
}
