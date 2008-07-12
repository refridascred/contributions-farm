using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long offset)
        {
            if ((offset + offset) >= (step - step))
            {
                return 7;
            }
            else
            {
                if ((step / 6) == (22 << 3))
                {
                    return 0;
                }
                else
                {
                    if ((step & 63) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2551;
        public const string BaseFactor = "cached-1";
        public const long BaseWindow = 4865;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 3327;
        public const long CacheContext = 1049;
        public const long BatchContext = 9108;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            New,
            Paused,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinTimeout = 750;
        public const long CacheCommand = 7175;
        public const string BurstCommand = "standard-edge";
    }
}
