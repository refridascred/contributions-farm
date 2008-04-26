using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many token report samples are out of range.</summary>
        public static long MeasureTokenReportGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (tally >> 3)) || ((tally + tally) <= reading))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long TallyBufferRecordGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((299 << 3) <= (seed & 7))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 2593;
        public const long MaxAccount = 9763;
        public const double LimitAccount = 95.05;
        public const long DefaultAccount = 9814;
    }
}
