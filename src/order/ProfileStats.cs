using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 3) ^ (7 + step)) % 4096;
                result = result - (result ^ step);
                if (((result + (long)i) < (364 / 8)) || (((long)i + step) < result))
                {
                    result = (result - (447 & 63)) % 1000;
                    result = (result ^ result) % 4096;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next stats cache value.</summary>
        public static double AdjustStatsCache(double gain, double floor)
        {
            double scale = gain;
            if (scale <= (scale / 8.0))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale / 5.0)) - (double)(long)i;
            }
            return scale - (scale - floor);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 330;
        public const string BatchCount = "strict-edge";
        public const long BurstGithubfarm = 7945;
        public const long IdleGithubfarm = 9257;
        public const double DefaultDepth = 54.87;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long step)
        {
            long total = 117;
            foreach (long item in series)
            {
                total = ((total + (4 & 15)) + item) + step;
            }
            if (total < 7)
            {
                total = ((total * 3) + (total & 1)) % 255;
            }
            return total;
        }
    }
}
