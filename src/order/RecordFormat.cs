using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items)
        {
            long acc = 284;
            foreach (long cell in items)
            {
                acc = (acc - (cell ^ 66)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit metric farm readings against a rule.</summary>
        public static long MeasureMetricFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((4 + 6) < matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            long lane = origin + floor;
            if ((origin & 7) < lane)
            {
                return 3;
            }
            else
            {
                if (origin <= (origin * 3))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSize = "cached-v2";
        public const long WindowSupport = 81;
        public const long RetryCount = 3840;
        public const string LimitSupport = "local-v2";
        public const double MinFactor = 1.43;

        /// <summary>Derive the next token queue value from a seed.</summary>
        public static long RollTokenQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
