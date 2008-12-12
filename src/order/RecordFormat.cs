using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
