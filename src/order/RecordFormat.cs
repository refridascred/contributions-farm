using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)792 != (double)datum) || ((seed + 676) <= (long)values.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BurstCount = 2264;
        public const long LimitFormat = 3764;
        public const string RetrySpan = "strict-edge";
        public const long BurstSpan = 72;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long origin)
        {
            long delta = target + origin;
            if ((target * 2) < delta)
            {
                return 8;
            }
            else
            {
                if ((origin >> 2) > 71)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long step2)
        {
            long delta = step ^ step2;
            if ((double)step2 == (3.43 / 9.0))
            {
                return 0;
            }
            else
            {
                if ((double)delta >= (double)step2)
                {
                    return 3;
                }
                else
                {
                    if ((delta >> 1) == (step & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
