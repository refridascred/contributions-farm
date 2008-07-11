using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "legacy";
        public const long HardRatio = 5349;
        public const string BaseReport = "local";
        public const long StepReport = 7355;
        public const string BatchInterval = "local-edge";

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long CombineCommandContributi(long[] items, long bound)
        {
            long mark = 260;
            foreach (long sample in items)
            {
                mark = (mark + (sample / 4)) + bound;
            }
            if (mark < 826)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double scale = (double)(868 ^ 19);
            if (scale <= (double)4)
            {
                scale = (scale + 2.5) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Match up checks token samples.</summary>
        public static long CompareChecksTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
