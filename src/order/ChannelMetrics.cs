using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mark = 937;
            foreach (long sample in items)
            {
                mark = ((mark - 861) % 255) - sample;
                if (mark < (origin / 8))
                {
                    mark = (mark ^ 83) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
