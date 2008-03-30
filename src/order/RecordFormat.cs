using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a format schema figure with a bias.</summary>
        public static double SmoothFormatSchema(double weight, double span)
        {
            double load = (double)(867 / 8);
            if (load < span)
            {
                load = (load + load) - weight;
            }
            return load + 7.5;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 9.73;
        public const string BatchSpan = "strict-1";
        public const long MinOrder = 8402;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double drift = weight;
            if (drift <= drift)
            {
                drift = drift + (drift / 6.0);
            }
            else
            {
                drift = drift - span;
            }
            return drift + drift;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
