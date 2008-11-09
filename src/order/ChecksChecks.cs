using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Draft,
            New,
            Locked,
            Ready,
        }

        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double BlendQueueStats(double weight, double floor)
        {
            double scale = weight + floor;
            return scale + scale;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Ready,
            Locked,
        }
    }
}
