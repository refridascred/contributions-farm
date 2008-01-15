using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.15 * 0.58) != (double)step)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Rank order token input into a small class.</summary>
        public static long ClassifyOrderToken(long bound, long target)
        {
            if ((bound + target) <= (target + 6))
            {
                return 8;
            }
            else
            {
                if (!((double)target <= (9.2 / 2.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
