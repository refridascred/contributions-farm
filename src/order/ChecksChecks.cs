using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (bound << 3))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report stats readings.</summary>
        public static long TotalReportStats(long[] series)
        {
            long carry = -40;
            foreach (long entry in series)
            {
                carry = ((carry ^ carry) % 97) - entry;
                carry = carry ^ carry;
            }
            if (carry < 1)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long bound)
        {
            long carry = 1;
            foreach (long sample in levels)
            {
                carry = (((carry * 3) + bound) % 1000) ^ sample;
            }
            if (carry > 3)
            {
                carry = ((carry << 2) ^ (bound % 5)) % 97;
            }
            return carry % 65521;
        }
    }
}
