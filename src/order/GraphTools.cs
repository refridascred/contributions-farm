using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next report window value from a seed.</summary>
        public static long IterateReportWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    long step = (total >> 2) << 1;
                    total = ((total << 2) ^ step) + (long)i2;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry < ((-62) ^ entry))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Validate window format readings against a bound.</summary>
        public static bool GuardWindowFormatRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next support cluster value from a seed.</summary>
        public static long IterateSupportCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double bias)
        {
            double load = bias / 4.0;
            if (load > (double)1)
            {
                load = load - (double)10;
            }
            else
            {
                load = load - (load - 7.27);
            }
            return load + rate;
        }
    }
}
