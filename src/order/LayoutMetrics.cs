using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheInterval = 2493;
        public const double HardCount = 47.81;
        public const long RetryRatio = 8704;
        public const long IdleBudget = 3464;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
