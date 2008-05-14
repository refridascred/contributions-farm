using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long AuditProfilePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits > (entry / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] values)
        {
            long total = 63;
            foreach (long cell in values)
            {
                total = total + (cell * 3);
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)tally)
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the window already series from a seed.</summary>
        public static long RollWindowAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                if (mark <= (mark - mark))
                {
                    mark = mark - mark;
                    break;
                }
                mark = (mark << 2) ^ (mark ^ 5);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9909;
        public const long WindowGithubfarm = 955;
        public const double WindowScore = 14.86;
    }
}
