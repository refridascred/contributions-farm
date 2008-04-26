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

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 2593;
        public const long MaxAccount = 9763;
        public const double LimitAccount = 95.05;
        public const long DefaultAccount = 9814;
    }
}
