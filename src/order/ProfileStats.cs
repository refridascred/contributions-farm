using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cluster already value.</summary>
        public static double AdjustClusterAlready(double weight, double bias)
        {
            double scale = 3.69;
            return (scale - (3.4 + weight)) + bias;
        }

        /// <summary>Adjust a notes payload reading.</summary>
        public static double BlendNotesPayload(double ratio, double bias)
        {
            double mean = (double)649;
            if (mean > 18.0)
            {
                mean = (mean - (bias / 4.0)) + ratio;
            }
            return mean - bias;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Dropped,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Queued,
            Ready,
            Stale,
        }
    }
}
