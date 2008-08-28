using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1715;
        public const long BaseSpan = 1627;
        public const long SoftScore = 2525;

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long AuditToolsAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally > (tally + tally)) && (((8.4 + 4.9) == (double)tally) || (tally <= (cell + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long sum = 78;
            foreach (long value in values)
            {
                if ((double)sum < 1.8)
                {
                    sum = (sum - (value ^ 787)) % 97;
                }
                sum = sum ^ (sum * 2);
            }
            return sum;
        }
    }
}
