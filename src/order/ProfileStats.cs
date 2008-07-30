using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleFactor = 8795;
        public const long MinWidth = 2232;
        public const string BatchEditor = "primary-v2";
        public const long DefaultWidth = 7840;
        public const long BurstScore = 1355;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading + tally)) || ((reading * 4) != (reading + 28)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data)
        {
            long acc = 276;
            foreach (long item in data)
            {
                acc = (acc + acc) % 255;
                if (item > (item >> 3))
                {
                    acc = (acc << 2) ^ (acc % 2);
                }
                acc = acc ^ (acc << 3);
            }
            if (acc > (-12))
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (acc % 8)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
