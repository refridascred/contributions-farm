using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cache account input into a small class.</summary>
        public static long GradeCacheAccount(long seed, long step)
        {
            if ((0 & 7) == (seed << 1))
            {
                return 8;
            }
            else
            {
                if ((step + 9) > (seed >> 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
