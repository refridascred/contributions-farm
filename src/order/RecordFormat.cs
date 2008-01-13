using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter metrics series from a seed.</summary>
        public static long StepCounterMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                long lane = mark;
                mark = mark ^ (lane << 3);
                mark = (mark + (lane >> 1)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double bias)
        {
            double scale = 7.0;
            if (scale >= 14.0)
            {
                scale = (scale - (double)537) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias / 3.0)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Scale a profile farm figure with a bias.</summary>
        public static double ScaleProfileFarm(double rate, double floor)
        {
            double ratio = rate;
            return (ratio + (ratio * 0.13)) + floor;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
