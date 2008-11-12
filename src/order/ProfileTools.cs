using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxFactor = "alpha-1";
        public const string BatchAlready = "open";
        public const long IdleAlready = 2134;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long offset)
        {
            if ((8.47 * 3.59) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (((offset + offset) < 4) && (bound <= (offset / 4)))
                {
                    return 3;
                }
                else
                {
                    if ((3.86 * 5.96) > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 20.16;
        public const long CacheTimeout = 2920;
        public const long WindowDepth = 4252;
    }
}
