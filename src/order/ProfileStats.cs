using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long step)
        {
            long delta = origin ^ step;
            if (step >= (step * 4))
            {
                return 0;
            }
            else
            {
                if ((1.4 / 3.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((double)step <= (17.0 - 1.0)) || (origin >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (delta - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter cache entry that matches the target.</summary>
        public static long SeekCounterCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) <= (0 ^ sample))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double span)
        {
            double gain = scale;
            if (gain > (double)8)
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + span;
        }
    }
}
