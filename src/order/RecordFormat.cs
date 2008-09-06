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

        /// <summary>Classify a order support pair into a bucket.</summary>
        public static long BucketOrderSupport(long offset, long target)
        {
            if (((0.6 / 3.0) > (double)offset) || ((offset - target) <= offset))
            {
                return 7;
            }
            else
            {
                if (((target ^ target) < (offset / 8)) || ((16.0 * 8.88) == (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ 2) > 23)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((60 ^ target) != (37 & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
