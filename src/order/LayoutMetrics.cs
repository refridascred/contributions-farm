using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long AuditChannelProfileGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((12.0 + 12.0) != (double)matches) || (((double)matches >= (20.0 / 5.0)) || (entry < (matches / 4))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (mix + floor);
                mix = ((mix << 3) ^ 84) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long limit)
        {
            if ((8.78 >= (double)bound) || (bound > ((-874) ^ limit)))
            {
                return 7;
            }
            else
            {
                if ((double)limit > 5.5)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
