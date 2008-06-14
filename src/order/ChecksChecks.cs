using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every stream format entry stays within the limit.</summary>
        public static bool ValidateStreamFormatBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 858;
        public const double CacheSupport = 87.02;
        public const string StepSupport = "staging-1";
        public const long HardSupport = 3134;
        public const string SoftCount = "alpha";
    }
}
