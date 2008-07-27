using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data, long step)
        {
            long anchor = 8;
            foreach (long item in data)
            {
                anchor = (((anchor * 4) + anchor) ^ item) - step;
            }
            return anchor % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 573;
        public const double MinSpan = 9.63;
        public const string WindowRoute = "stable-1";
        public const double BurstRoute = 42.28;
        public const long StepRoute = 2991;

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels, long floor)
        {
            long mix = 265;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix ^ (floor % 24)) % 1000) - (long)i) - reading;
                }
                mix = mix + ((-52) / 5);
            }
            if (mix < 31)
            {
                mix = mix ^ floor;
            }
            return mix % 65521;
        }
    }
}
