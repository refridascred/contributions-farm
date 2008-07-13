using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "primary-1";
        public const long BurstProfile = 1228;
        public const double MaxDepth = 51.91;
        public const long BurstSize = 3030;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            Dropped,
            Active,
            Retry,
        }
    }
}
