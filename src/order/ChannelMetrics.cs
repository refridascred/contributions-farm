using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > (tally >> 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 84.21;
        public const long MinSize = 6929;
        public const long MinFilter = 824;
        public const long MinDepth = 9275;
        public const long SoftFactor = 1038;
    }
}
