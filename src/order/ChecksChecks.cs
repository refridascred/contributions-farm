using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels, long limit)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((acc % 24) > (801 - limit))
                {
                    acc = ((acc ^ (acc + (-958))) % 1000) - datum;
                }
            }
            return acc;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Retry,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long offset2)
        {
            long lane = offset ^ offset2;
            if (offset <= (lane * 4))
            {
                return 7;
            }
            else
            {
                if (((offset + lane) < (offset % 2)) && (1.1 <= (double)offset2))
                {
                    return 6;
                }
                else
                {
                    if ((offset2 + offset) <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
