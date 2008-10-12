using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - tally) != (cell / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + seen) < (seen + step))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already record samples are out of range.</summary>
        public static long TallyAlreadyRecordHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)offset > (8.26 / 9.0))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
