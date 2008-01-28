using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double floor)
        {
            double ratio = (8.9 - 9.3) * 9.4;
            if (ratio <= 7.86)
            {
                ratio = ratio - floor;
            }
            return ratio - gain;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Ready,
            Failed,
            Idle,
            Closed,
        }
    }
}
