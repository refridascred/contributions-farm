using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double span)
        {
            double weight = (double)(69 % 3);
            if (weight >= (weight / 6.0))
            {
                weight = ((weight - (double)601) - rate) - span;
            }
            else
            {
                weight = weight + 5.0;
            }
            return weight + weight;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Failed,
            Done,
        }
    }
}
