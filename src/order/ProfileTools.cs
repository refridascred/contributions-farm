using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8114;
        public const string RetryFormat = "latest";
        public const long HardSpan = 7578;
        public const long MinFormat = 5323;

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long BatchBuffer = 2977;
        public const double StepTimeout = 55.55;
        public const long BaseBuffer = 7696;
        public const double SoftSpan = 70.8;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            New,
            Done,
            Draft,
            Active,
        }
    }
}
