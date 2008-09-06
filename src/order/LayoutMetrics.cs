using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Paused,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a route channel reading.</summary>
        public static double BlendRouteChannel(double ratio, double floor)
        {
            double drift = (double)684 + (double)969;
            if (drift >= (3.3 / 4.0))
            {
                drift = drift - ratio;
            }
            return drift + floor;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Retry,
            Dropped,
            Locked,
            Active,
        }
    }
}
