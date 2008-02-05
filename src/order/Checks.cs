using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double drift = 3.0;
            if (drift < 1.91)
            {
                drift = drift - (drift / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (ratio * 6.9)) + (double)(long)i;
            }
            return drift - (ratio + bias);
        }

        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long SeekProfileFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "fallback-1";
        public const string DefaultRatio = "staging";
        public const string MinChecks = "fallback-edge";

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
