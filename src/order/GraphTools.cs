using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long seed, long origin)
        {
            long bound = seed ^ origin;
            if (!(3 > bound))
            {
                return 7;
            }
            else
            {
                if (((9.4 / 3.0) < (double)origin) && ((6.7 / 2.0) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double mean = rate;
            if (mean > (6.87 / 6.0))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long acc = 52;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (entry ^ entry)) ^ (long)i;
                }
                if ((double)limit <= 14.0)
                {
                    acc = (acc + entry) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 3) + (limit / 4)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 7585;
        public const double IdleCache = 89.16;
        public const long MaxScore = 985;
        public const long MinCache = 1803;
    }
}
