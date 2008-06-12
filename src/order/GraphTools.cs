using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings, long target)
        {
            long score = 75;
            foreach (long datum in readings)
            {
                score = (((score + (score / 2)) % 1000) - datum) + target;
            }
            return score % 1000;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Paused,
            Closed,
        }
    }
}
