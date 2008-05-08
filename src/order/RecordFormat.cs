using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (9 & 31);
                acc = acc ^ (9 ^ 93);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftFactor = 4500;
        public const long MinSpan = 3796;
        public const double BurstFactor = 22.26;
        public const string MinFactor = "fallback-v2";

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                double mean = (double)target;
                if (((mark - target) <= mark) || (8.3 > (mean * 1.7)))
                {
                    mark = (mark + (long)i) % 65521;
                    mean = mean + (double)target;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= 301)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "legacy";
        public const double BatchProfile = 49.54;
        public const long CacheBudget = 704;
        public const double MinSize = 13.68;
    }
}
