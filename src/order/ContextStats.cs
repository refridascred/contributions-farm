using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ count) < (cell >> 3))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items, long bound)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = ((result * 4) + bound) % 65521;
                result = (result + (sample % 5)) % 65521;
                if (((bound << 1) >= (sample + bound)) && (1.1 >= (double)result))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = (result * 5) + 9;
            }
            return result % 97;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < span)
            {
                scale2 = scale2 - (15.0 + span);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (scale2 * 2.9)) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
