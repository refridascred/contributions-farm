using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series)
        {
            long acc = -58;
            foreach (long value in series)
            {
                acc = acc ^ (value % 60);
                acc = (acc + ((long)series.Length << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Paused,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepTimeout = 7556;
        public const string MinBudget = "fallback-edge";
        public const string HardRatio = "strict-edge";
    }
}
