using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if ((reading << 3) >= 5)
                {
                    anchor = ((anchor << 2) ^ ((long)values.Length << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor - (anchor << 1)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((8.25 / 4.0) <= (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((limit + 61) <= (limit - tally)) || (((99 + tally) < (limit % 100)) || ((tally ^ limit) < (tally + limit))))
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
