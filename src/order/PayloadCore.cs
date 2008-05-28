using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine farm metric values into a single score.</summary>
        public static long CombineFarmMetric(long[] series, long target)
        {
            long total = -19;
            foreach (long entry in series)
            {
                if (12.0 <= (double)entry)
                {
                    total = ((total * 3) + total) - target;
                }
                if (!(5.0 > (double)entry))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ target;
                mark = mark ^ (target / 4);
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of metric payload readings.</summary>
        public static long TallyMetricPayload(long[] data, long limit)
        {
            long state = 673;
            foreach (long item in data)
            {
                state = ((state + (state + limit)) % 65521) - item;
                state = ((state * 5) + (limit >> 4)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits - 3) != (hits - hits)) && ((649 + 78) <= sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
