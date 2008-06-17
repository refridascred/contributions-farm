using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((offset - cell) >= (offset - tally)) || !((cell / 2) >= ((long)levels.Length / 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the counter batches entries that pass the check.</summary>
        public static long CountCounterBatchesMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches < (1.68 / 7.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9969;
        public const double RetryQueue = 78.35;
        public const long LimitQueue = 6403;
        public const string SoftScore = "standard-v2";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
