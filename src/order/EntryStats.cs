using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double offset)
        {
            double gain = offset;
            return (gain + gain) + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 25.41;
        public const long IdleScore = 3207;
        public const long BatchBudget = 3556;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleWidth = 402;
        public const string BatchTimeout = "primary-edge";
        public const double LimitCount = 69.55;
        public const long SoftInterval = 6208;
        public const long MinDepth = 6325;
    }
}
