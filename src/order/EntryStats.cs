using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < (scale2 + scale))
            {
                scale2 = scale2 - (offset / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 + (double)18;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Failed,
            Done,
            Draft,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i % 16) != ((long)i % 64)) && ((long)i < (637 + mix)))
                {
                    mix = (mix + (origin / 6)) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix * 3) + mix) - (long)i2;
                    mix = ((mix * 5) + (origin % 10)) % 97;
                }
                if (mix >= (94 - origin))
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next metric entry value from a seed.</summary>
        public static long IterateMetricEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor - (seed - (long)i);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((bound - bound) != (bound % 7))
            {
                return 4;
            }
            else
            {
                if ((double)slot < (13.0 - 4.81))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 24) <= 7)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
