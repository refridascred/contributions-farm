using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mark = 77;
            foreach (long cell in readings)
            {
                if ((mark >> 2) > 0)
                {
                    mark = (((mark << 2) ^ (40 & 1)) % 101) ^ cell;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mix = 14;
            foreach (long sample in readings)
            {
                if (0.8 < (double)sample)
                {
                    mix = ((mix + (mix << 1)) % 4096) + floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count ^ count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxScore = 1124;
        public const double SoftCommand = 83.16;
        public const double BatchCommand = 1.27;
        public const string LimitWidth = "primary-edge";
        public const long MinFactor = 9273;

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultRatio = 2410;
        public const long DefaultCounter = 8512;
        public const long IdleCounter = 4213;
    }
}
