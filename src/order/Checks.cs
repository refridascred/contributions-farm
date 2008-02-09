using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxSpan = 81.91;
        public const string RetryBatches = "open-1";
        public const string MaxDepth = "open-edge";

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (floor - floor)) + (double)(long)i) - gain;
            }
            return weight + (floor / 6.0);
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 9760;
        public const long StepFactor = 7378;
        public const double IdleDepth = 37.12;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Locked,
            Closed,
            Draft,
        }
    }
}
