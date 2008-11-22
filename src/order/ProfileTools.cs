using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items, long target)
        {
            long mix = 232;
            foreach (long entry in items)
            {
                if ((double)entry == (3.69 / 9.0))
                {
                    mix = (((mix << 2) ^ (entry & 1)) % 255) + target;
                }
                mix = (mix - 0) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double ratio = (offset + scale) / 3.0;
            if (ratio >= scale)
            {
                ratio = ratio - (double)7;
            }
            return ratio - (double)273;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double gain = (floor / 2.0) * 5.2;
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double load = rate - floor;
            if (load < load)
            {
                load = load + 6.0;
            }
            else
            {
                load = load + (5.0 + 11.0);
            }
            return load - (floor - floor);
        }
    }
}
