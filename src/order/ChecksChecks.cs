using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 1385;
        public const long DefaultDepth = 7222;
        public const long HardFactor = 9230;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((83 + origin) < (origin ^ entry)) && ((entry / 4) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long step)
        {
            if ((4 > (step & 7)) && ((1.99 - 9.0) <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((9.9 / 2.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((8.5 + 7.0) != (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
