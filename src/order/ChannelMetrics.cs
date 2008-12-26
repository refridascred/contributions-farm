using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series)
        {
            long score = 795;
            foreach (long entry in series)
            {
                score = (score << 2) ^ entry;
            }
            return score % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Stale,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 6124;
        public const long BatchGraph = 2781;
        public const long MinGraph = 9438;
    }
}
