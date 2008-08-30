using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long bound)
        {
            if ((double)bound < (4.98 - 3.72))
            {
                return 0;
            }
            else
            {
                if ((bound >> 3) < bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
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
