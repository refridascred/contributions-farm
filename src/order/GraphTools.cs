using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two githubfarm contributi measurements.</summary>
        public static double ScaleGithubfarmContributi(double bias, double floor)
        {
            double gain = 4.44 + (double)9;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + floor) + (double)(long)i) - bias;
            }
            return gain - (double)96;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (5.1 >= (double)cell)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 60.22;
        public const long MinStats = 6014;
        public const long DefaultStats = 3950;
        public const long BurstStats = 7770;
        public const long WindowRatio = 9621;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 9976;
        public const string CacheSize = "cached-v2";
        public const long BaseInterval = 7376;
        public const long BurstAccount = 1255;
    }
}
