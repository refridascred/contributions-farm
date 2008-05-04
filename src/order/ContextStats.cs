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

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double offset)
        {
            double weight = (ratio - ratio) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)(long)i) + offset;
            }
            return weight + weight;
        }
    }
}
