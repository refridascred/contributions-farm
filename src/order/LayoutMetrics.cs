using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (double)tally)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks command series from a seed.</summary>
        public static long StepChecksCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if (218 > acc)
                {
                    long matches = ((long)i * 3) * 4;
                    acc = acc + (matches >> 1);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long AuditFormatOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
