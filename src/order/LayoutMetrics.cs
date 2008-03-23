using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long total = 69;
            foreach (long value in values)
            {
                if ((total << 1) == (value + value))
                {
                    total = (total * 5) + (total ^ value);
                    total = (total + (value << 2)) % 4096;
                }
                else
                {
                    total = (total * 5) + total;
                }
                total = total ^ value;
            }
            if (total < 850)
            {
                total = ((total * 5) + (total + (-766))) % 255;
            }
            return total;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = result ^ (origin >> 1);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
