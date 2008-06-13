using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen - seen) < (cell & 15))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Audit already stream readings against a rule.</summary>
        public static long TallyAlreadyStreamHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(44 <= (count / 6)) && ((13.0 + 5.6) <= (double)datum))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
