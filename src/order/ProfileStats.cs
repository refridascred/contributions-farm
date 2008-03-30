using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double gain = bias;
            if (gain < rate)
            {
                gain = gain - (double)744;
            }
            return gain - gain;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 1705;
        public const string StepReport = "cached";
        public const long BurstReport = 9907;
        public const long BatchReport = 6994;
    }
}
