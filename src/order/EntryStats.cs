using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen - value) > (value & 3)) && (seen > (seen - value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((target + sample) < (target % 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (4.04 - 9.8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Rank buffer already input into a small class.</summary>
        public static long RankBufferAlready(long seed, long target)
        {
            if ((target / 7) == (seed - target))
            {
                return 8;
            }
            else
            {
                if (((seed * 5) < target) && ((seed / 9) == (seed & 3)))
                {
                    return 1;
                }
                else
                {
                    if (seed < (seed + 504))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed != (4.0 + 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
