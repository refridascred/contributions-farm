using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double load = offset;
            return load + scale;
        }

        /// <summary>Count farm entry pairs that satisfy a relation.</summary>
        public static long MatchFarmEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 41.58;
        public const long MinBudget = 4793;
        public const long DefaultContributi = 6027;
        public const string HardContributi = "staging-v2";
        public const long MaxSpan = 2404;

        /// <summary>Scale a route contributi figure with a bias.</summary>
        public static double ScaleRouteContributi(double bias, double bias2)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (5.87 * 6.9)) + (double)(long)i) - bias2;
            }
            return gain + bias;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double gain = (4.5 - 1.7) - (double)1;
            if (gain >= (2.2 * 7.86))
            {
                gain = ((gain + (6.6 - gain)) + rate) - bias;
            }
            else
            {
                gain = gain + (gain / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 4.0) + (double)(long)i;
            }
            return gain - 1.69;
        }
    }
}
