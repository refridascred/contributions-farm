using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha-edge";
        public const string BurstSchema = "stable";
        public const long StepWidth = 388;
        public const long StepSchema = 896;

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "alpha-v2";
        public const long RetrySupport = 1152;
        public const long BurstInterval = 9504;
        public const long IdleSpan = 1657;
        public const long MinSupport = 8639;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
