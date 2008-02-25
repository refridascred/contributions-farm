using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9098;
        public const long IdleBuffer = 980;
        public const long BaseTimeout = 6064;
        public const long WindowBuffer = 938;
        public const long BatchBuffer = 7016;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                long delta = seed;
                if ((result - delta) != ((-167) * 3))
                {
                    delta = ((delta << 2) ^ ((long)i % 12)) % 255;
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank context counter input into a small class.</summary>
        public static long GradeContextCounter(long offset, long step)
        {
            long gap = offset + step;
            if ((gap + gap) >= offset)
            {
                return 5;
            }
            else
            {
                if ((6.4 * 2.0) == (double)step)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
