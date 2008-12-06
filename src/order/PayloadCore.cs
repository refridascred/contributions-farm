using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7.25 < (double)sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "standard-edge";
        public const double HardInterval = 26.8;
        public const long IdleBuffer = 5003;

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long TallyChannelCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((3.5 >= (double)item) || ((item / 3) == (342 - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double span)
        {
            double gain = span;
            if (gain >= (double)40)
            {
                gain = (gain + (double)4) - bias;
            }
            else
            {
                gain = gain - (span - span);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (span / 9.0)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
