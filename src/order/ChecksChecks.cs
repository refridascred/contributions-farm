using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long anchor = 7;
            foreach (long value in readings)
            {
                if (value >= (value + value))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                if ((38 - anchor) <= (anchor & 127))
                {
                    break;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor % 4096;
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
