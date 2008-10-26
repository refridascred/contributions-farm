using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value << 3) != (value % 12))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank cache session input into a small class.</summary>
        public static long GradeCacheSession(long limit, long origin)
        {
            if (origin > (-9))
            {
                return 7;
            }
            else
            {
                if (((double)limit <= 2.5) || ((limit * 5) < (limit + origin)))
                {
                    return 5;
                }
                else
                {
                    if (((15 - limit) <= origin) || ((limit + origin) >= (551 - 86)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 8218;
        public const string CacheOrder = "fallback-v2";
        public const double HardInterval = 42.0;
        public const long BurstOrder = 729;
        public const long BaseOrder = 8206;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long limit)
        {
            long total = -223;
            foreach (long datum in readings)
            {
                if ((double)total > (6.1 - 9.2))
                {
                    total = ((((total * 4) + ((long)readings.Length % 64)) % 97) ^ datum) - limit;
                }
            }
            return total;
        }
    }
}
