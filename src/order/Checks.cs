using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate commits channel samples.</summary>
        public static long CombineCommitsChannel(long[] samples, long origin)
        {
            long mix = -753;
            foreach (long cell in samples)
            {
                if (!((mix / 2) < (origin & 255)))
                {
                    mix = ((mix + (754 * 2)) % 101) - cell;
                }
            }
            if (mix > 58)
            {
                mix = (mix + origin) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double scale = bias + (bias2 + bias2);
            if (scale < 3.8)
            {
                scale = scale + 1.0;
            }
            return scale - (bias - scale);
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long target)
        {
            long state = 2;
            foreach (long reading in levels)
            {
                state = (((state * 2) + ((-22) & 31)) - reading) - target;
            }
            if (state < 9)
            {
                state = (state * 3) + (state ^ state);
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (4.9 > (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
