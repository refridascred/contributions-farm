using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Audit schema channel readings against a rule.</summary>
        public static long TallySchemaChannelHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (10.0 - 1.6))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long step)
        {
            if (298 < (floor % 16))
            {
                return 1;
            }
            else
            {
                if (floor <= (floor >> 4))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two support metrics measurements.</summary>
        public static double ScaleSupportMetrics(double gain, double bias)
        {
            double load = 2.12;
            if (load >= (gain / 2.0))
            {
                load = load + (double)1;
            }
            else
            {
                load = load - (load * 9.75);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load + (double)(-58);
        }
    }
}
