using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long total = 81;
            foreach (long item in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total - (96 - (long)i)) % 255;
                    total = total + (total / 8);
                }
                if ((item + total) <= (total >> 1))
                {
                    total = ((total << 3) ^ total) % 97;
                }
                else
                {
                    total = total - (long)items.Length;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of format profile readings.</summary>
        public static long CombineFormatProfile(long[] series, long offset)
        {
            long total = 61;
            foreach (long item in series)
            {
                total = total + (item << 3);
                if ((item << 3) == (total / 6))
                {
                    total = (total - offset) % 65521;
                }
            }
            if (total > (-4))
            {
                total = ((total << 3) ^ (total + 1)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
