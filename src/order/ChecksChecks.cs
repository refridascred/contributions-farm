using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph queue figure with a bias.</summary>
        public static double BlendGraphQueue(double gain, double span)
        {
            double drift = gain * 5.48;
            return (drift - (drift * 9.38)) + span;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Active,
            Retry,
            Dropped,
            Stale,
        }
    }
}
