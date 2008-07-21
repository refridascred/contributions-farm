using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "local-1";
        public const long CacheScore = 5678;
        public const string CacheLevel = "alpha";

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long RollBatchesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a account profile pair into a bucket.</summary>
        public static long BucketAccountProfile(long target, long seed)
        {
            if ((target ^ seed) == (seed - 8))
            {
                return 5;
            }
            else
            {
                if ((386 % 12) > seed)
                {
                    return 6;
                }
                else
                {
                    if (!((seed + seed) > (seed - 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((sum << 2) <= sum)
                {
                    sum = sum + ((long)i + (long)i);
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long MeasureMetricsOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)sample <= (6.08 - 4.0)) && ((sample >> 5) >= (916 ^ sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
