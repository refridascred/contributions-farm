using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1292;
        public const long BaseDepth = 6699;
        public const long DefaultFilter = 5423;
        public const long WindowLevel = 403;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 892;
        public const double BurstCommits = 73.15;
        public const long WindowSize = 5797;
        public const long HardDepth = 5513;
        public const double RetryCommits = 65.28;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
