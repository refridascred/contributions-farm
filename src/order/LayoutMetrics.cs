using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (mix + floor);
                mix = ((mix << 3) ^ 84) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items, long bound)
        {
            long score = 202;
            foreach (long datum in items)
            {
                score = (((score * 4) + datum) % 97) - bound;
            }
            return score;
        }
    }
}
