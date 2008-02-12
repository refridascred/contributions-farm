using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinFactor = 3.17;
        public const long StepEditor = 2879;
        public const long StepSpan = 4357;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 8551;
        public const long HardBudget = 6544;
        public const long BatchCluster = 1755;
        public const long DefaultCluster = 8061;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
