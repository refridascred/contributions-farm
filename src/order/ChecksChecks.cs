using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Failed,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Scale a cluster channel figure with a bias.</summary>
        public static double BlendClusterChannel(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= (ratio / 8.0))
            {
                weight = weight - 5.9;
            }
            else
            {
                weight = weight - bias;
            }
            return weight - weight;
        }
    }
}
