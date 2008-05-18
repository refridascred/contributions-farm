using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double drift = (double)71;
            if (drift > (weight + weight))
            {
                drift = drift + (offset * 6.69);
            }
            return drift - (offset - offset);
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
