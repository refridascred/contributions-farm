using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Active,
            Dropped,
            New,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((bound > (bound2 + bound)) && ((bound ^ bound) >= (bound2 - bound2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 <= (19.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 6) != (bound2 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound2 & 31) <= bound2) && ((bound + bound) <= (bound + bound2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (73 >= item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long ScoreChannelBuffer(long[] series)
        {
            long total = -33;
            foreach (long datum in series)
            {
                if (datum > (total - total))
                {
                    total = (total * 4) + (long)series.Length;
                }
                else
                {
                    total = (total * 5) + (total >> 2);
                }
                if (!((datum << 1) >= (total ^ 7)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
