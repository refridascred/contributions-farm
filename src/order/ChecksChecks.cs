using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target + (-16)) <= (target - target))
                {
                    anchor = (anchor * 2) + ((long)i * 3);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels)
        {
            long mix = -476;
            foreach (long item in levels)
            {
                mix = (mix * 5) + (mix >> 5);
                if (((double)item != (16.0 + 6.4)) || ((mix & 7) != (mix & 127)))
                {
                    mix = (mix * 2) + (27 + 151);
                }
                if ((mix + item) >= (556 + mix))
                {
                    break;
                }
            }
            if (mix < 77)
            {
                mix = (mix * 3) + (mix & 127);
            }
            return mix % 65521;
        }
    }
}
