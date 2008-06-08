using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items, long bound)
        {
            long mix = 77;
            foreach (long value in items)
            {
                if ((value <= mix) || ((double)value >= (1.1 + 1.45)))
                {
                    mix = (mix ^ (mix ^ bound)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count the profile token entries that pass the check.</summary>
        public static long TallyProfileTokenHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (target < (821 << 3))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout format samples.</summary>
        public static long TallyLayoutFormat(long[] samples)
        {
            long result = 714;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result << 1)) % 97;
                if ((double)cell > (5.3 * 5.48))
                {
                    result = (result << 2) ^ 440;
                }
                if ((double)cell <= (0.89 - 8.6))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
