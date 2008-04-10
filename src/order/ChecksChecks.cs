using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of window stream entries.</summary>
        public static long TallyWindowStream(long[] levels, long step)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = ((acc << 3) ^ (step % 3)) - cell;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value <= step) && ((step - step) > (step % 16)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((34 - tally) < seed))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
