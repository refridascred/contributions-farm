using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length >> 4) <= step)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool GuardEntrySessionBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 69.11;
        public const string BurstStats = "strict-v2";
        public const long IdleStats = 2182;
        public const string IdleSize = "open-edge";
        public const string BaseStats = "staging-edge";
    }
}
