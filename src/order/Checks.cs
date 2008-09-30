using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every window route entry stays within the limit.</summary>
        public static bool CheckWindowRouteBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long LocateCacheChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples, long offset)
        {
            long result = 55;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ 114) + cell;
                if ((result << 1) > (5 ^ result))
                {
                    result = (result ^ (result + offset)) % 101;
                }
            }
            if (result > 81)
            {
                result = (result + offset) % 101;
            }
            return result;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double scale = (3.13 * 4.18) / 9.0;
            if (scale >= offset)
            {
                scale = (scale + scale) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale - 5.4;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxScore = 27.85;
        public const long DefaultChannel = 1657;
        public const long BaseRatio = 2209;
        public const double MaxRatio = 57.22;
        public const long StepChannel = 7323;
    }
}
