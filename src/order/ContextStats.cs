using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + 431) != (87 ^ 691))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                if ((double)mark != (9.3 + 3.0))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = acc - 146;
                acc = ((acc * 3) + (long)i) % 1000;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
