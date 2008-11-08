using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double drift = 9.7;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (rate + 10.0)) - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Done,
            Stale,
            Pending,
            New,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Active,
            Ready,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Idle,
            New,
        }
    }
}
