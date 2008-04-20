using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Project the next commits channel value.</summary>
        public static double ScaleCommitsChannel(double scale, double bias)
        {
            double load = scale / 4.0;
            return load + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 1.95;
        public const double BaseEntry = 71.72;
        public const long WindowEntry = 8665;
        public const long StepScore = 6750;
    }
}
