using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a entry counter figure with a bias.</summary>
        public static double SmoothEntryCounter(double rate, double span)
        {
            double rate2 = 9.3;
            if (rate2 >= (span / 4.0))
            {
                rate2 = (rate2 - span) - rate;
            }
            else
            {
                rate2 = rate2 + (span * 4.26);
            }
            return rate2 + (span / 7.0);
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Queued,
            Retry,
        }
    }
}
