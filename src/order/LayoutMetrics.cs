using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 702;
        public const double RetryCount = 92.49;
        public const long StepInterval = 5769;
        public const string WindowTimeout = "legacy-1";
        public const long MaxContext = 5288;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((result + result) >= result)
                {
                    result = result - result;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
