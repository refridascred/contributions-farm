using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes contributi samples are out of range.</summary>
        public static long CountNotesContributiOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((sample << 3) > count) || !((20.0 / 8.0) > (double)sample))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value * 5) == ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 356;
        public const long SoftBatch = 3770;
        public const long DefaultBatch = 7809;
        public const long HardBatch = 8308;
        public const double BurstScore = 72.22;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((mix - 93) < (bound - bound))
                {
                    mix = (mix << 2) ^ (bound - value);
                }
                else
                {
                    mix = ((mix << 2) ^ value) % 97;
                }
            }
            return mix;
        }
    }
}
