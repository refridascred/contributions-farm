using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySize = 7914;
        public const long HardProfile = 2363;
        public const long MaxProfile = 588;
        public const long CacheProfile = 3047;
        public const long IdleSize = 4553;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 483;
        public const double BatchWindow = 25.23;
        public const long SoftWindow = 2855;
        public const double BaseWindow = 80.52;
        public const long IdleFactor = 2516;
    }
}
