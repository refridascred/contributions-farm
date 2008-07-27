using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next channel layout value.</summary>
        public static double SmoothChannelLayout(double rate, double span)
        {
            double load = (double)5 * 9.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - span) + (double)(long)i) - rate;
            }
            return load - (double)9;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4558;
        public const long MinRoute = 4444;
        public const long HardRoute = 6079;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxSize = 2111;
        public const long HardFarm = 6259;
        public const double IdleFactor = 67.7;
    }
}
