using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "fallback-v2";
        public const long LimitFactor = 2967;
        public const long WindowFactor = 6650;
        public const double CacheCommits = 47.94;
        public const long RetryCommits = 4147;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next cache support value from a seed.</summary>
        public static long RollCacheSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result + result)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - (floor + floor);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
