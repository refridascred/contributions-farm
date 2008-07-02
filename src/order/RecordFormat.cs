using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((value ^ 89) < (seen - value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "local-1";
        public const long IdleCount = 6703;
        public const long BurstWidth = 8832;
        public const long CacheFactor = 7019;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
