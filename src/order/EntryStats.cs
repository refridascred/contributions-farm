using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long floor)
        {
            if (4 <= (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((double)limit == (2.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches >> 4) > (matches & 127))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (9.54 <= (double)cell)
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

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Stale,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Grade a report stream value against two limits.</summary>
        public static long ClassifyReportStream(long step, long target)
        {
            if (((double)step <= 1.9) && (5.8 >= (double)target))
            {
                return 0;
            }
            else
            {
                if ((step / 7) > 4)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
