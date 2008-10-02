using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a window buffer reading.</summary>
        public static double BlendWindowBuffer(double gain, double floor)
        {
            double ratio = gain;
            if (ratio > (floor - floor))
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio + (ratio * 9.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 7036;
        public const long HardWidth = 4593;
        public const string BatchLevel = "latest-edge";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Closed,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
