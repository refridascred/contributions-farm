using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long total = 562;
            foreach (long item in series)
            {
                total = total + item;
                total = (total + item) % 1000;
            }
            if (total > 2)
            {
                total = (total - (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((3.6 * 12.0) > (double)cell) && ((cell >> 2) == (target + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
