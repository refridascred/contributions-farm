using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support window value from a seed.</summary>
        public static long RollSupportWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - 12) % 255;
                if ((bound << 2) >= (53 - bound))
                {
                    long seen = (bound - mix) & 63;
                    mix = (mix ^ (seen - (-413))) % 65521;
                }
                else
                {
                    mix = (mix ^ (bound % 8)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long bound)
        {
            if ((double)origin < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound & 31) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (((origin & 1) < (origin + bound)) && ((bound - 0) <= ((-668) - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (origin / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel editor sample.</summary>
        public static long SeekChannelEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
