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

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
