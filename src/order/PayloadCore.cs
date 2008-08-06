using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((double)step != (double)1) || (total < step))
                {
                    total = total - (total + total);
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every schema checks entry stays within the limit.</summary>
        public static bool ValidateSchemaChecksBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + (limit + limit)) % 255;
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "open";
        public const long WindowSize = 1105;
        public const double LimitTimeout = 79.54;
    }
}
