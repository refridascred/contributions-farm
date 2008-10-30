using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Active,
            Idle,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSize = 4048;
        public const string SoftSchema = "stable-v2";
        public const double DefaultWidth = 75.05;

        /// <summary>Count the filter account entries that pass the check.</summary>
        public static long MeasureFilterAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((long)readings.Length + item) < (count * 3)) && ((double)item == (double)(long)readings.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long seed)
        {
            long slot = bound + seed;
            if (((slot % 8) <= (bound - 34)) && ((double)seed == (16.0 + 2.0)))
            {
                return 0;
            }
            else
            {
                if ((slot ^ slot) >= (527 / 8))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
