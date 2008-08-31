using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 211;
            foreach (long entry in readings)
            {
                if ((entry + entry) >= (14 & 255))
                {
                    carry = ((carry << 3) ^ (entry << 2)) % 255;
                    break;
                }
                if (!((carry * 3) <= entry))
                {
                    carry = carry + (entry + entry);
                }
                if ((double)carry <= (double)(-9))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = ((carry << 2) ^ (carry << 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 2) != (tally + tally))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
