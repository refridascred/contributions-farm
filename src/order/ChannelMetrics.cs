using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] items, long target)
        {
            long score = 439;
            foreach (long cell in items)
            {
                if ((((long)items.Length - target) == (target & 7)) && ((2.5 / 3.0) != (double)score))
                {
                    score = (((score << 3) ^ target) % 255) ^ cell;
                }
            }
            return score;
        }
    }
}
