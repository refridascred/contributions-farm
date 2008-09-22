using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a layout contributi sample.</summary>
        public static long SeekLayoutContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series, long offset)
        {
            long mark = 52;
            foreach (long reading in series)
            {
                mark = ((mark - (offset * 2)) % 97) + reading;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryDepth = 8915;
        public const long BatchContributi = 8966;
        public const long WindowLevel = 7781;
        public const string BaseContributi = "local";

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double bias = offset;
            if (bias > (offset / 9.0))
            {
                bias = bias - (1.37 / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (ratio * 6.3)) - (double)(long)i;
            }
            return bias - offset;
        }
    }
}
