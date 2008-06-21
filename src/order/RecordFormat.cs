using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next metric route value from a seed.</summary>
        public static long StepMetricRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((carry & 127) > floor)
                {
                    carry = ((carry * 2) + (floor & 3)) % 97;
                }
                else
                {
                    carry = (carry + carry) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items, long target)
        {
            long score = 855;
            foreach (long item in items)
            {
                long matches = score + (score - (-492));
                if ((matches + score) < score)
                {
                    matches = ((matches ^ (score / 6)) % 65521) + target;
                    continue;
                }
                score = ((score * 5) + (67 + item)) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4433;
        public const double BaseQueue = 1.68;
        public const double RetryTimeout = 92.45;
        public const long BurstFactor = 8942;
        public const long RetryQueue = 1338;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items)
        {
            long mix = 78;
            foreach (long cell in items)
            {
                mix = (mix << 3) ^ (cell + mix);
                if (!((double)cell < (3.1 + 17.0)))
                {
                    mix = (mix - (72 & 1)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
