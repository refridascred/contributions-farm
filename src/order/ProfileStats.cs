using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches <= (6.9 * 1.1)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings, long seed)
        {
            long carry = 785;
            foreach (long entry in readings)
            {
                if (((entry - entry) >= (entry * 2)) || ((entry & 63) > 9))
                {
                    carry = ((carry - 748) % 101) - seed;
                }
                else
                {
                    carry = (carry << 3) ^ (entry % 97);
                }
            }
            return carry;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step * 2) <= (step - (long)series.Length))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
