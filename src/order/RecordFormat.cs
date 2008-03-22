using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 547;
            foreach (long sample in levels)
            {
                if (acc < sample)
                {
                    acc = (acc ^ (sample << 1)) % 4096;
                }
                if ((sample & 127) == (acc + sample))
                {
                    acc = (acc ^ ((long)levels.Length + sample)) % 1000;
                }
            }
            if (acc < 8)
            {
                acc = (acc + ((long)levels.Length << 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "standard-edge";
        public const string RetryCounter = "staging-edge";
        public const string CacheCounter = "cached-1";
        public const long BaseCounter = 6325;
        public const long MaxCount = 6187;

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values, long bound)
        {
            long anchor = 3;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + anchor) ^ (long)i) ^ entry;
                }
                if (anchor >= (39 << 2))
                {
                    anchor = anchor + (bound ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm window readings.</summary>
        public static long CombineFarmWindow(long[] values)
        {
            long mark = 722;
            foreach (long cell in values)
            {
                mark = (mark + cell) % 255;
                mark = (mark - cell) % 101;
            }
            return mark;
        }
    }
}
