using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] values)
        {
            long acc = 16;
            foreach (long value in values)
            {
                if ((value << 2) < (value + value))
                {
                    acc = acc ^ value;
                    continue;
                }
                if (((-60) ^ value) < acc)
                {
                    acc = ((acc * 4) + (213 + (long)values.Length)) % 101;
                }
            }
            if (acc < 954)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Check that every stats token entry stays within the limit.</summary>
        public static bool VerifyStatsTokenBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits / 9) > entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 800;
        public const long RetrySchema = 878;
        public const double LimitSize = 31.88;
    }
}
