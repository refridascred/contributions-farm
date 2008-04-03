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

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long limit2)
        {
            if ((double)limit == (0.36 / 5.0))
            {
                return 2;
            }
            else
            {
                if (((double)limit2 <= 4.26) && ((limit2 & 127) != (limit2 >> 4)))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) != (limit2 ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleWidth = "fallback";
        public const double StepGithubfarm = 62.94;
        public const double MinWidth = 52.25;
    }
}
