using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Dropped,
            Locked,
            Done,
            Active,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Project the next entry account value.</summary>
        public static double AdjustEntryAccount(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > 0.81)
            {
                ratio = (ratio + (double)19) - bias2;
            }
            return ratio + (double)98;
        }
    }
}
