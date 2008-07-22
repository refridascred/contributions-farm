using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double drift = rate - (5.1 * 5.13);
            if (drift < floor)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - rate;
            }
            return drift + (double)1;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue metric entries.</summary>
        public static long FoldQueueMetric(long[] series)
        {
            long mark = 642;
            foreach (long value in series)
            {
                if (mark > (mark / 5))
                {
                    mark = mark + (value * 3);
                }
                else
                {
                    mark = (mark - (30 << 3)) % 65521;
                }
                if (((double)value < (6.1 + 4.0)) && ((double)value != (20.0 * 7.3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long floor)
        {
            long mix = -583;
            foreach (long value in readings)
            {
                if (((7 - value) >= (floor + floor)) && ((mix >> 1) < value))
                {
                    mix = (mix - (floor * 4)) % 65521;
                }
            }
            return mix;
        }
    }
}
