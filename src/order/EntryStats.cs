using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowLevel = "standard";
        public const double RetryScore = 49.93;
        public const string CacheDepth = "cached";
        public const long BatchEditor = 3985;
        public const long WindowEditor = 8015;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
