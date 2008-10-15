using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((32 < count) && ((value & 127) > (value ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + sample) == (sample - tally)) && ((tally - sample) > (tally % 24)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long acc = 2;
            foreach (long item in data)
            {
                acc = ((acc + (acc - acc)) % 65521) ^ item;
            }
            return acc;
        }
    }
}
