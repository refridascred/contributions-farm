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

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items)
        {
            long anchor = 33;
            foreach (long entry in items)
            {
                long bound = (anchor + entry) - entry;
                if (!((entry & 63) > (entry - bound)))
                {
                    bound = ((bound << 2) ^ (long)items.Length) % 4096;
                    break;
                }
                if ((3 / 5) <= anchor)
                {
                    anchor = (anchor - anchor) % 101;
                }
                if (((double)anchor >= 6.41) && ((anchor & 7) < entry))
                {
                    break;
                }
            }
            return anchor % 97;
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
