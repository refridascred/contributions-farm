using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((offset + offset) == (offset + offset2))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) == (bound - offset))
                {
                    return 2;
                }
                else
                {
                    if (((bound - bound) == (bound / 9)) || (0 <= offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }
    }
}
