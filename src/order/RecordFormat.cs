using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6985;
        public const string CacheSpan = "cached-1";
        public const double BaseFactor = 77.27;
        public const long BurstReport = 4838;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxSize = 3213;
        public const long MinContext = 4162;
        public const long IdleContext = 1840;
        public const long BatchSize = 1944;
        public const long HardContext = 7670;

        /// <summary>Rank checks report input into a small class.</summary>
        public static long ClassifyChecksReport(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (diff >= (diff / 6))
            {
                return 1;
            }
            else
            {
                if (diff < (0 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!(((-56) / 8) < (seed2 >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed < (4.5 * 9.54))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double mean = gain;
            if (mean <= (floor - gain))
            {
                mean = mean - 9.5;
            }
            else
            {
                mean = mean - (double)230;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)4) - (double)(long)i;
            }
            return mean + 7.32;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
