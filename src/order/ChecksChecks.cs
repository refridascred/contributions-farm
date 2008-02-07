using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next schema cache value.</summary>
        public static double AdjustSchemaCache(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (scale / 9.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum & 31) <= (bound - seen)) || ((double)seen != (17.0 - 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((5 >> 3) >= (tally - entry)) || (((double)tally >= (double)entry) && ((653 & 127) > (tally + tally))))
                {
                    tally = tally + 1;
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
