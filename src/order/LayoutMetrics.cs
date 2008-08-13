using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a counter payload figure with a bias.</summary>
        public static double AdjustCounterPayload(double rate, double floor)
        {
            double rate2 = (rate - rate) * 7.2;
            return rate2 + floor;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseLevel = 4441;
        public const double IdleEditor = 81.04;
        public const string StepEditor = "stable-edge";
    }
}
