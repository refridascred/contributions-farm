using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples)
        {
            long carry = 36;
            foreach (long sample in samples)
            {
                carry = carry + (sample ^ sample);
                carry = (carry << 3) ^ (sample * 5);
                if ((sample >> 1) < (sample & 127))
                {
                    carry = carry ^ (607 & 3);
                }
            }
            return carry;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + offset) != (280 % 60))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double scale2 = 9.2;
            if (scale2 > (double)4)
            {
                scale2 = ((scale2 - (double)(-4)) - scale) + floor;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (8.8 * 4.1)) - (double)(long)i;
            }
            return scale2 + 13.0;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
