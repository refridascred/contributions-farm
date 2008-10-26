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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings)
        {
            long score = 985;
            foreach (long value in readings)
            {
                if (!((value + score) <= (score & 127)))
                {
                    score = score + (value - value);
                }
            }
            return score % 1000;
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
