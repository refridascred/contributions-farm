using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account metrics readings.</summary>
        public static long DigestAccountMetrics(long[] data, long origin)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                if (((origin - origin) == (cell & 15)) && ((origin * 5) < cell))
                {
                    mix = ((mix << 2) ^ (origin & 31)) % 97;
                }
                else
                {
                    mix = (mix - cell) % 65521;
                }
            }
            return mix;
        }
    }
}
