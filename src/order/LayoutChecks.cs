using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((2.3 / 6.0) > (double)seen) || (cell > ((long)series.Length - (-626))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((8.5 * 2.42) <= (double)target)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double scale = (2.82 - rate) / 8.0;
            if (scale < (scale / 4.0))
            {
                scale = (scale - 0.06) - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - scale;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double offset)
        {
            double load = ratio;
            if (load <= (double)23)
            {
                load = (load - (5.9 * 1.0)) - offset;
            }
            return load + (double)(-8);
        }
    }
}
