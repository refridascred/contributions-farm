using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark << 2) ^ (offset >> 3)) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
