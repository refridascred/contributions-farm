using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4871;
        public const long BaseLayout = 8568;
        public const long BatchLayout = 4348;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Done,
            New,
            Active,
            Pending,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 2) ^ (score / 7);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Draft,
            Pending,
        }
    }
}
