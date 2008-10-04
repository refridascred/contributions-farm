using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5445;
        public const double RetryReport = 96.79;
        public const double WindowReport = 44.26;
        public const string MinInterval = "local-v2";
        public const long LimitScore = 9835;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((-98) <= (count * 3))
                {
                    count = ((count + 3) ^ entry) + target;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardFactor = 8589;
        public const string WindowContext = "fallback-edge";
        public const long BurstTimeout = 4076;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (total & 63)) % 97;
                total = (total ^ ((long)i + (long)i)) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
