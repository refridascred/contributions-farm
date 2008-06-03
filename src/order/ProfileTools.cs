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

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Locked,
            Ready,
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

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long mark = 242;
            foreach (long entry in data)
            {
                if (!((mark >> 5) != (mark - 4)))
                {
                    mark = ((mark * 2) + 3) ^ entry;
                }
            }
            return mark;
        }
    }
}
