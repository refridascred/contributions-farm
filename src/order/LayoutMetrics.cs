using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of cache order readings.</summary>
        public static long ScoreCacheOrder(long[] values)
        {
            long mark = 25;
            foreach (long value in values)
            {
                mark = (mark ^ mark) % 255;
                if ((20.0 + 7.2) >= (double)value)
                {
                    mark = (mark ^ value) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (value & 127);
                }
            }
            return mark;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long floor)
        {
            long sum = -3;
            foreach (long entry in series)
            {
                sum = (sum - entry) - floor;
                sum = (sum ^ (entry % 5)) % 97;
            }
            if (sum > 71)
            {
                sum = (sum + (sum / 3)) % 1000;
            }
            return sum % 1000;
        }
    }
}
