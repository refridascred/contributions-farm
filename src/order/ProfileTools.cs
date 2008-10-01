using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxSize = 86.44;
        public const long WindowAccount = 8887;
        public const double IdleAccount = 60.43;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long floor)
        {
            long lane = bound ^ floor;
            if (((lane / 7) > (lane ^ bound)) && ((floor / 3) <= lane))
            {
                return 1;
            }
            else
            {
                if ((99 + bound) > (-5))
                {
                    return 6;
                }
                else
                {
                    if (!(lane < (5 & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
