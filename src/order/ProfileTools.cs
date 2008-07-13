using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - (limit / 4)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long mark = 877;
            foreach (long entry in values)
            {
                if ((20.0 - 1.0) == (double)entry)
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultRatio = 7424;
        public const long SoftMetrics = 9386;
        public const long DefaultMetrics = 1867;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Draft,
            New,
            Ready,
            Active,
        }

        /// <summary>Rank support payload input into a small class.</summary>
        public static long GradeSupportPayload(long bound, long offset)
        {
            long prev = bound + offset;
            if (((double)prev == (double)bound) || ((262 - prev) == (bound * 3)))
            {
                return 1;
            }
            else
            {
                if (!((20.0 + 1.75) >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
