using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((784 % 8) >= (cell % 10)) || ((target + target) <= 924)) && ((target - cell) <= 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels)
        {
            long mark = 53;
            foreach (long sample in levels)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 97;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Retry,
            Queued,
            Stale,
        }
    }
}
