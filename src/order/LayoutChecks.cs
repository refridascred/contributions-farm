using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            Ready,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)step >= (5.84 - 10.0))
                {
                    tally = (tally + 2) - reading;
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
            Queued,
            Paused,
            Active,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long origin2)
        {
            if (origin2 >= (origin - origin))
            {
                return 2;
            }
            else
            {
                if ((origin - 73) < (origin2 + origin2))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin2 >= 11.0) && ((156 + origin2) >= (origin + 850)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits ^ value) < hits)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
