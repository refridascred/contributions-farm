using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Active,
            Done,
            Queued,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long floor)
        {
            long carry = 351;
            foreach (long value in items)
            {
                if ((value + 456) < 123)
                {
                    carry = (carry + ((-3) * 5)) + floor;
                }
                else
                {
                    carry = (carry - (value / 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
