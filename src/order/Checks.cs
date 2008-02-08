using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 50;
            foreach (long entry in samples)
            {
                if (89 >= ((-3) - entry))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
                anchor = (anchor * 3) + (anchor << 3);
                if (((7.3 + 7.9) == (double)anchor) && (anchor < entry))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Draft,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long offset, long target)
        {
            if (((offset + offset) == (offset * 3)) && ((offset & 63) >= (offset * 3)))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) < (offset ^ 48))
                {
                    return 4;
                }
                else
                {
                    if (((double)target <= (double)offset) || (offset <= (offset + 853)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset >= 6.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long TallyReportCacheGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item <= (matches + 8)) && ((item % 12) <= matches))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
