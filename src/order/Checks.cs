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

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long limit)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                if (!((2.84 / 2.0) < (4.0 + 3.2)))
                {
                    mark = (mark + ((long)readings.Length / 8)) % 101;
                }
                mark = (mark << 3) ^ (cell << 1);
                mark = ((mark << 3) ^ mark) % 101;
                if ((limit >= cell) || ((limit - limit) >= (cell << 2)))
                {
                    break;
                }
            }
            return mark;
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
