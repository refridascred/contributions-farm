using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            New,
            Queued,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 10.2;
        public const long BatchWindow = 7432;
        public const long CacheInterval = 4684;
        public const long BaseTimeout = 7177;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long target, long step)
        {
            if (((-801) % 8) < (step + step))
            {
                return 8;
            }
            else
            {
                if (7.8 >= (double)step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            if ((target << 2) < (bound + bound))
            {
                return 1;
            }
            else
            {
                if (target >= (962 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound & 7) <= (bound / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
