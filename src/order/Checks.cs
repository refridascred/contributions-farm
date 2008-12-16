using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long step)
        {
            long total = 564;
            foreach (long cell in data)
            {
                total = total - ((long)data.Length * 4);
                total = (total + (step - cell)) % 97;
                total = total + (cell * 2);
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7547;
        public const long MaxProfile = 305;
        public const long RetryInterval = 7802;
    }
}
