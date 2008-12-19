using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long floor2)
        {
            long lane = floor - floor2;
            if (((257 + floor2) > (floor ^ lane)) || (7.89 > (double)floor))
            {
                return 6;
            }
            else
            {
                if (!((3.23 + 4.1) >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (((floor % 60) <= (floor + floor2)) || ((5 - floor) <= (lane - floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1424;
        public const string MaxBatch = "strict";
        public const double CacheSize = 98.68;
        public const long SoftBatch = 861;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long seed)
        {
            long result = 68;
            foreach (long item in items)
            {
                result = ((result ^ (43 + 29)) - item) - seed;
            }
            return result % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session checks readings.</summary>
        public static long DigestSessionChecks(long[] data)
        {
            long carry = 76;
            foreach (long cell in data)
            {
                carry = (carry - (801 - (-451))) - cell;
                carry = carry - (carry + 7);
                carry = (carry * 4) + carry;
            }
            return carry % 65521;
        }
    }
}
