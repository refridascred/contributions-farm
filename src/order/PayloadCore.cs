using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Closed,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Queued,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double drift = (bias2 - 2.22) / 2.0;
            if (drift <= (bias - 19.0))
            {
                drift = drift - (bias * 7.69);
            }
            else
            {
                drift = drift + (double)(-212);
            }
            return drift - (bias2 + bias2);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Closed,
            Synced,
        }
    }
}
