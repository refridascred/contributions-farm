using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally << 2) < tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double bias, double bias2)
        {
            double rate = (bias / 4.0) + bias2;
            if (rate < bias)
            {
                rate = rate + (double)43;
            }
            else
            {
                rate = rate + (bias - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 2.84) + (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowRatio = "open-edge";
        public const long BaseCommand = 7655;
        public const double LimitLevel = 39.04;
        public const double BurstTimeout = 65.64;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}
