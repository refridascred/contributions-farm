using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (123 > (sample << 1))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((carry * 5) + (cell - (-4))) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally & 63) >= (961 >> 1))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
