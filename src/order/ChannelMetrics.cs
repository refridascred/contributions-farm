using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm commits pair into a bucket.</summary>
        public static long GradeFarmCommits(long limit, long limit2)
        {
            if (!((double)limit >= 5.95))
            {
                return 4;
            }
            else
            {
                if (((4.0 * 0.2) >= (double)limit2) || ((limit2 + limit2) >= limit))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit2 > (0.5 - 2.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit2 <= (limit / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin <= (origin - state)) || (60 <= origin)))
                {
                    state = (state + ((long)i - 864)) % 255;
                }
                state = (state << 3) ^ state;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
