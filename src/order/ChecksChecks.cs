using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i - (long)i) <= ((long)i & 3)))
                {
                    mix = mix + (long)i;
                }
                mix = ((mix << 3) ^ (mix - mix)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
