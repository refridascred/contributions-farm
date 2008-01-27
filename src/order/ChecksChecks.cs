using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items, long limit)
        {
            long total = 5;
            foreach (long value in items)
            {
                if (((7.0 / 9.0) < (double)value) && ((value + value) >= (value - 624)))
                {
                    total = ((total << 2) ^ (1 >> 3)) % 65521;
                }
                else
                {
                    total = (total - (limit >> 5)) % 1000;
                }
            }
            if (total < 2)
            {
                total = total ^ 30;
            }
            return total;
        }

        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long SeriesBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (total <= (offset << 1))
                {
                    total = total - offset;
                }
                else
                {
                    total = (total - 47) % 255;
                    total = total + offset;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 2) != (matches / 8))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
