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

        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long MeasureProfileMetricHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((tally % 97) != (tally & 15)) && ((7 - 7) < (long)readings.Length))
                {
                    tally = ((tally + 1) - cell) + target;
                }
            }
            return tally;
        }
    }
}
