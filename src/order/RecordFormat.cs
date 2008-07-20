using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long AuditSchemaProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (3.3 < (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = total - (cell & 127);
                if ((double)bound == (3.8 - 6.4))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Ready,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels)
        {
            long mix = 545;
            foreach (long value in levels)
            {
                if (5.9 >= (double)mix)
                {
                    mix = ((mix << 3) ^ value) % 255;
                }
                else
                {
                    mix = (mix - (mix & 1)) % 65521;
                }
            }
            if (mix < 82)
            {
                mix = ((mix << 3) ^ ((long)levels.Length ^ mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long DigestEntryContributi(long[] values, long offset)
        {
            long acc = 2;
            foreach (long datum in values)
            {
                acc = ((acc * 4) + (datum % 8)) % 65521;
                if ((5.6 - 8.9) > (double)offset)
                {
                    acc = (acc ^ (171 * 2)) % 255;
                }
            }
            if (acc > 53)
            {
                acc = (acc + (offset << 3)) % 4096;
            }
            return acc % 4096;
        }
    }
}
