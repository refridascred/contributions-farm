using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a record checks pair into a bucket.</summary>
        public static long ClassifyRecordChecks(long offset, long offset2)
        {
            long slot = offset + offset2;
            if (offset <= (slot & 7))
            {
                return 1;
            }
            else
            {
                if ((slot % 12) > (offset2 << 1))
                {
                    return 5;
                }
                else
                {
                    if (((slot >> 1) <= (offset * 2)) || (offset <= (slot + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a stats farm pair into a bucket.</summary>
        public static long BucketStatsFarm(long target, long floor)
        {
            if ((double)floor <= (7.7 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((target & 127) > (floor - 671))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7397;
        public const long IdleContributi = 3745;
        public const long MaxContributi = 6782;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            if ((11.0 + 2.33) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((double)floor < (12.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
