using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((-22) + datum) < datum) || ((matches ^ datum) == (datum ^ 669)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepScore = "primary";
        public const double MaxAccount = 31.04;
        public const double SoftCount = 98.4;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ (total ^ limit)) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 1276;
        public const double BaseTimeout = 48.6;
        public const long SoftReport = 153;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Locked,
            Synced,
            New,
        }
    }
}
