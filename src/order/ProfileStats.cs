using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultRatio = 0.73;
        public const long MaxWindow = 3904;
        public const string IdleWindow = "alpha-1";
        public const string BaseInterval = "strict-edge";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((4 / 3) >= (matches << 2))
                {
                    matches = ((matches + 3) + datum) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long target)
        {
            if ((14.0 / 4.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if (seed >= (seed << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
