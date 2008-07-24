using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 3215;
        public const long LimitSize = 9812;
        public const long MaxProfile = 64;

        /// <summary>Blend two profile format measurements.</summary>
        public static double ProjectProfileFormat(double bias, double floor)
        {
            double weight = (double)6;
            if (weight >= (double)186)
            {
                weight = (weight + floor) + bias;
            }
            return weight - weight;
        }
    }
}
