using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long origin)
        {
            if ((origin + origin) != (bound ^ origin))
            {
                return 3;
            }
            else
            {
                if ((7.0 - 4.5) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings)
        {
            long mix = 352;
            foreach (long sample in readings)
            {
                if ((4.0 * 7.67) <= (double)mix)
                {
                    mix = ((mix << 2) ^ (sample << 3)) % 65521;
                }
                else
                {
                    mix = (mix + 2) % 4096;
                }
            }
            if (mix > 3)
            {
                mix = (mix - (mix >> 3)) % 255;
            }
            return mix;
        }
    }
}
