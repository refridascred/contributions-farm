using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 196;
            foreach (long reading in series)
            {
                acc = acc + reading;
            }
            return acc % 4096;
        }

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
