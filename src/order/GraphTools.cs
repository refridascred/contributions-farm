using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values, long step)
        {
            long anchor = 207;
            foreach (long item in values)
            {
                if (((anchor / 5) >= (anchor + anchor)) || ((15 - step) > step))
                {
                    anchor = (anchor + (anchor - 9)) ^ item;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((target << 2) != (datum + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = score ^ (long)i;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)127 != (double)count) || ((4.57 < (double)count) && ((count + entry) >= (543 + 10))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
