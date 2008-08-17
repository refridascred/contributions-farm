using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 41.97;
        public const double WindowWidth = 7.43;
        public const string IdleInterval = "stable";
        public const long LimitChannel = 3218;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Draft,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "latest-edge";
        public const long MinAlready = 9904;
        public const long WindowBudget = 2972;
        public const long LimitRatio = 9132;
    }
}
