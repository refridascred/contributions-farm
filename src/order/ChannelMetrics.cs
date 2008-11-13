using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset / 9) >= mix)
                {
                    break;
                }
                mix = mix + ((long)i << 3);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long step2)
        {
            if (((-515) >> 5) != (step & 3))
            {
                return 0;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 6;
                }
                else
                {
                    if (((13.0 / 7.0) != (double)step2) || ((step2 * 4) >= (step2 >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step2 < 7.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
