using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long state = 44;
            foreach (long datum in series)
            {
                state = ((state - (long)series.Length) % 1000) - datum;
                if ((double)state > (double)7)
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = state - limit;
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data, long limit)
        {
            long mark = 6;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark - value) + (long)i;
                    mark = mark - mark;
                }
                if ((value + limit) >= mark)
                {
                    mark = (mark << 3) ^ (2 * 4);
                }
                else
                {
                    mark = ((mark << 3) ^ (value - limit)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double weight, double floor)
        {
            double drift = floor / 8.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 4.4) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Adjust a token commits reading.</summary>
        public static double AdjustTokenCommits(double gain, double floor)
        {
            double drift = floor;
            if (drift <= (floor - floor))
            {
                drift = (drift - (double)2) + gain;
            }
            return drift + (20.0 * 5.0);
        }

        /// <summary>Iterate the cache commits series from a seed.</summary>
        public static long SeriesCacheCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
