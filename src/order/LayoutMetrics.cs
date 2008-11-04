using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit - mark) != (limit >> 5))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (limit - limit)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
