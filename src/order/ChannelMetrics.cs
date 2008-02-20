using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4753;
        public const long MinGraph = 8884;
        public const double StepGraph = 15.57;
        public const double HardGraph = 18.43;
        public const long BaseRatio = 2265;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Synced,
            Idle,
            New,
            Pending,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double rate, double floor)
        {
            double scale = floor;
            return (scale + (floor - scale)) + rate;
        }
    }
}
