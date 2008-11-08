using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate report account samples.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length > (cell - cell))
                {
                    acc = (acc ^ cell) % 101;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 71;
            }
            return acc % 65521;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Active,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxTimeout = "legacy-1";
        public const double RetryInterval = 22.84;
        public const long IdleSize = 7668;
        public const string StepContext = "local";
        public const long BaseBudget = 8582;
    }
}
