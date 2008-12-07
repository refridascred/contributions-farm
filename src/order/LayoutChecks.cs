using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Synced,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Audit githubfarm counter readings against a rule.</summary>
        public static long TallyGithubfarmCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= 14.0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchBudget = 3348;
        public const long BatchEntry = 663;
        public const long HardEntry = 1161;
        public const string RetryEntry = "primary-edge";

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
