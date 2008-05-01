using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Locked,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double weight = bias;
            if (weight >= ratio)
            {
                weight = weight + (ratio - 0.66);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)103) + (double)(long)i;
            }
            return weight - 1.6;
        }
    }
}
