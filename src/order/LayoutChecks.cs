using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLevel = 7620;
        public const double BatchSize = 92.63;
        public const long BatchLevel = 2857;
        public const string HardLayout = "primary-v2";

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Queued,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long floor)
        {
            long mark = 262;
            foreach (long cell in items)
            {
                if (!((floor + mark) <= (cell * 3)))
                {
                    mark = (mark ^ ((-7) << 1)) % 97;
                }
                else
                {
                    mark = mark - (floor * 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats session samples.</summary>
        public static long DigestStatsSession(long[] series)
        {
            long mark = 613;
            foreach (long item in series)
            {
                if (item >= (item & 63))
                {
                    mark = mark - (mark << 3);
                }
            }
            return mark % 97;
        }
    }
}
