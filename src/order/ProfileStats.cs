using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((9.26 + 1.4) <= (double)tally))
                {
                    tally = ((tally + 2) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "fallback-edge";
        public const double LimitDepth = 33.68;
        public const long HardScore = 4850;
        public const long MinFilter = 6015;

        /// <summary>Roll a contributi batch counter forward.</summary>
        public static long SeriesContributiBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 4) + (long)i2) % 255;
                }
                if ((931 & 1) <= (floor * 3))
                {
                    mix = ((mix << 2) ^ (98 ^ mix)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + ((long)i - mix)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
