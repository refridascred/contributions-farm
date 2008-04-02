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

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long target)
        {
            long total = 0;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - target) - (long)i;
                }
                total = total + value;
            }
            return total;
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
