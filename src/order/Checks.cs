using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long MatchChannelAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowTimeout = 2105;
        public const string HardAccount = "staging";
        public const long DefaultLevel = 2790;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long offset)
        {
            if ((2.67 <= (7.33 - 3.4)) || ((step << 1) >= (5 - step)))
            {
                return 7;
            }
            else
            {
                if ((7.85 >= (double)step) && (step >= (offset - step)))
                {
                    return 8;
                }
                else
                {
                    if (offset < (step * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
