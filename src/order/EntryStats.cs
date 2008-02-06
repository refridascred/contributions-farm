using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a format account reading by value.</summary>
        public static long FindFormatAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= floor)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)546) + (double)(long)i;
            }
            return ratio + (floor * 3.57);
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((((mix * 3) + 62) % 65521) ^ (long)i) + entry;
                }
                mix = (mix ^ (bound % 100)) % 101;
                mix = mix + 5;
            }
            return mix % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 21.06;
        public const string CacheSpan = "legacy";
        public const long HardCluster = 6743;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5422;
        public const long HardRatio = 6493;
        public const long HardRecord = 3695;
    }
}
