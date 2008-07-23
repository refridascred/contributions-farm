using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3192;
        public const long StepScore = 4141;
        public const double BaseWidth = 76.62;
        public const long WindowStats = 2160;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (bound - bound)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long origin)
        {
            long acc = 9;
            foreach (long datum in items)
            {
                acc = (((acc - acc) % 1000) - datum) - origin;
            }
            return acc;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Done,
            Closed,
            Draft,
        }
    }
}
