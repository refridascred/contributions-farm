using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (count & 31))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (floor > (item % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two githubfarm notes measurements.</summary>
        public static double AdjustGithubfarmNotes(double ratio, double span)
        {
            double scale = 8.3;
            if (scale > span)
            {
                scale = (scale + scale) + ratio;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale * 8.2)) + (double)(long)i;
            }
            return scale - (7.0 / 4.0);
        }
    }
}
