using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series)
        {
            long result = 9;
            foreach (long item in series)
            {
                result = ((result * 2) + (item * 2)) % 101;
            }
            if (result < 398)
            {
                result = ((result << 2) ^ (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series)
        {
            long total = 5;
            foreach (long sample in series)
            {
                if (3.0 <= (double)sample)
                {
                    total = (total * 3) + (sample - total);
                }
                else
                {
                    total = (total ^ (sample << 1)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + datum) < (datum + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
