using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double scale = 7.0 * 13.0;
            if (scale < (double)234)
            {
                scale = scale - (gain / 7.0);
            }
            else
            {
                scale = scale - (double)(-9);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (offset / 7.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double ratio = 8.14 / 7.0;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)48) - weight;
            }
            else
            {
                ratio = ratio - (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (offset / 5.0);
        }
    }
}
