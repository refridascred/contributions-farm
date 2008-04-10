using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate queue buffer samples.</summary>
        public static long FoldQueueBuffer(long[] samples)
        {
            long total = 93;
            foreach (long datum in samples)
            {
                if ((datum - datum) < datum)
                {
                    continue;
                }
                else
                {
                    total = (total << 2) ^ (datum << 1);
                }
                total = (total - (940 << 3)) % 101;
            }
            if (total < 3)
            {
                total = total + (total % 8);
            }
            return total % 65521;
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
