using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long total = 902;
            foreach (long item in series)
            {
                total = ((total - 9) % 4096) + item;
            }
            if (total < 812)
            {
                total = (total + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Validate cache report readings against a bound.</summary>
        public static bool VerifyCacheReportBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value - matches) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples)
        {
            long state = 339;
            foreach (long item in samples)
            {
                if ((item >> 4) != (item ^ state))
                {
                    state = state ^ (item * 3);
                }
            }
            return state;
        }
    }
}
