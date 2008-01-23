using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Validate commits checks readings against a bound.</summary>
        public static bool CheckCommitsChecksLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
