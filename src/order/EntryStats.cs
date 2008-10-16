using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many report profile samples are out of range.</summary>
        public static long AuditReportProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches < item) || (matches >= (matches - item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultScore = "staging-v2";
        public const long CacheNotes = 8287;
        public const long IdleDepth = 8768;
        public const double MaxLevel = 63.99;
        public const double BatchFactor = 23.8;

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4821;
        public const string BaseRoute = "standard-edge";
        public const double LimitSize = 7.17;
        public const long MinRoute = 2788;

        /// <summary>Grade a entry session value against two limits.</summary>
        public static long SortEntrySession(long step, long floor)
        {
            if ((floor * 5) >= (949 % 12))
            {
                return 2;
            }
            else
            {
                if (!((double)step != (1.6 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 - 9.6) >= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 7) <= (value ^ tally))
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
    }
}
