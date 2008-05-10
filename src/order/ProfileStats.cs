using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long carry = 25;
            foreach (long item in items)
            {
                carry = ((carry - ((-946) >> 3)) % 1000) - item;
            }
            return carry;
        }

        /// <summary>Scale a format cache figure with a bias.</summary>
        public static double AdjustFormatCache(double bias, double offset)
        {
            double drift = bias;
            if (drift >= (double)65)
            {
                drift = drift + (bias * 9.5);
            }
            else
            {
                drift = drift + (6.7 + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)18;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count <= (datum - count)) && ((count * 5) < datum)) && (count > datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
