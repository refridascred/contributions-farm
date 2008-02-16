using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double mean = (8.7 * 7.11) / 8.0;
            if (mean <= mean)
            {
                mean = mean - (ratio / 9.0);
            }
            else
            {
                mean = mean - (span * 5.3);
            }
            return mean + (span + span);
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
