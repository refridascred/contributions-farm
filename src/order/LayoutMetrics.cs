using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every payload cluster entry stays within the limit.</summary>
        public static bool ValidatePayloadClusterBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix - (mix * 4)) % 4096;
                if ((long)i <= (mix + bound))
                {
                    break;
                }
                else
                {
                    mix = mix - (mix >> 2);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
