using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of support metric readings.</summary>
        public static long ScoreSupportMetric(long[] readings, long seed)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (seed >= total)
                {
                    total = (total << 2) ^ (seed * 3);
                }
                total = total ^ (total * 3);
                total = ((total * 3) + (value & 255)) % 101;
            }
            return total;
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
