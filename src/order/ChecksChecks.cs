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

        /// <summary>Audit farm counter readings against a rule.</summary>
        public static long MeasureFarmCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally - tally) < item))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
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
