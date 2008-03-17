using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (bias2 + span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (1.0 * 0.1)) + (double)(long)i;
            }
            return bias2 + (bias - 4.0);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 3.0) != (double)matches)
                {
                    matches = ((matches + 3) + datum) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 7940;
        public const long BurstCount = 5370;
        public const long MinFarm = 1719;
        public const long WindowWidth = 766;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
