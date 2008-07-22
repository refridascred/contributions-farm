using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values, long limit)
        {
            long mark = 660;
            foreach (long sample in values)
            {
                if (((double)mark <= 12.0) || (((long)values.Length / 8) > (mark % 60)))
                {
                    mark = mark ^ sample;
                }
            }
            if (mark < 78)
            {
                mark = (mark << 2) ^ (limit ^ (-44));
            }
            return mark;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i / 4) >= bound))
                {
                    score = score - (score - bound);
                    score = (score + 86) % 65521;
                }
                score = score ^ score;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context metrics value.</summary>
        public static double ProjectContextMetrics(double ratio, double floor)
        {
            double mean = (double)(8 + 89);
            if (mean <= ratio)
            {
                mean = mean - floor;
            }
            return mean - (floor - mean);
        }
    }
}
