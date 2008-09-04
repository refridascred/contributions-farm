using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long step)
        {
            if ((31 & 3) < floor)
            {
                return 5;
            }
            else
            {
                if ((floor << 3) <= (step / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 12) > 226))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (floor - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record githubfarm entries that pass the check.</summary>
        public static long CountRecordGithubfarmMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((14.0 / 4.0) < (double)reading) && ((double)step <= (double)reading)) && (((step & 7) >= matches) || ((step + matches) < reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Synced,
            Paused,
            New,
            Closed,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
