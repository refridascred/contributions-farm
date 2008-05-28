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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total + total) % 101;
                if ((total >> 5) != (total / 8))
                {
                    total = ((total * 2) + (origin >> 4)) % 255;
                    continue;
                }
                total = (total + ((long)i + total)) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
