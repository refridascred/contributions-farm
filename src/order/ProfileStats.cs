using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double drift = (double)((-68) - 80);
            return ((drift + (4.6 - drift)) + scale) + span;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 4823;
        public const string RetryReport = "local-edge";
        public const long IdleScore = 2067;
        public const long DefaultScore = 4508;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
