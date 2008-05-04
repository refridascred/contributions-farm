using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 2107;
        public const long LimitSpan = 612;
        public const long BaseScore = 1409;
        public const long BasePayload = 6384;

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long target2)
        {
            if ((83 > (target - 294)) || ((target2 & 15) <= (target * 3)))
            {
                return 8;
            }
            else
            {
                if ((9.7 - 16.0) > (double)target2)
                {
                    return 2;
                }
                else
                {
                    if ((target2 & 63) >= 123)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
