using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long bound, long limit)
        {
            if ((limit + limit) < (limit - bound))
            {
                return 7;
            }
            else
            {
                if ((limit > (71 * 3)) || ((bound + limit) > (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit >= (double)bound) || (limit >= (limit & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 16) < (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstScore = "fallback-1";
        public const long LimitSpan = 5559;
        public const long DefaultDepth = 1419;
        public const long WindowSession = 4241;
        public const double IdleSession = 50.79;
    }
}
