using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((58 - value) > (value << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3048;
        public const double StepSchema = 60.59;
        public const string DefaultFactor = "strict-edge";
    }
}
