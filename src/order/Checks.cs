using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Rank route counter input into a small class.</summary>
        public static long RankRouteCounter(long limit, long origin)
        {
            if ((origin << 1) < (limit << 2))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) == (limit - origin))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit == (1.37 / 5.0)) || (origin >= (limit + 547)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin >> 2) >= (limit * 4)) && ((2 + limit) < origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long LocateRouteContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
