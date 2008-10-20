using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long bound)
        {
            long score = 9;
            foreach (long item in data)
            {
                if ((item - score) >= (894 - item))
                {
                    score = score + (item >> 2);
                }
            }
            if (score > 93)
            {
                score = (score ^ (bound + bound)) % 101;
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double ratio = span;
            if (ratio < span)
            {
                ratio = (ratio + (ratio + span)) - gain;
            }
            return ratio + (ratio - span);
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long mark = 4;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ mark) - value;
            }
            return mark % 4096;
        }
    }
}
