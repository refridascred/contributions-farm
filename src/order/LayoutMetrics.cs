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

        /// <summary>Check that every farm account entry stays within the limit.</summary>
        public static bool CheckFarmAccountLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
