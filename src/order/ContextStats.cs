using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long carry = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry + (carry + origin)) - (long)i;
                }
                if ((824 + 1) == (carry + (long)levels.Length))
                {
                    carry = ((carry * 5) + (carry - (long)levels.Length)) % 255;
                    continue;
                }
                else
                {
                    carry = (carry + origin) % 97;
                    carry = carry ^ (37 + (-7));
                }
                if (((carry + carry) < (5 * 3)) || ((origin - carry) > (25 % 8)))
                {
                    carry = (carry << 2) ^ ((-6) / 9);
                }
                else
                {
                    carry = carry ^ sample;
                }
            }
            if (carry > 358)
            {
                carry = (carry + (origin + origin)) % 4096;
            }
            return carry;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double ratio = 8.14 / 7.0;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)48) - weight;
            }
            else
            {
                ratio = ratio - (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (offset / 5.0);
        }
    }
}
