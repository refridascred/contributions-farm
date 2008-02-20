using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long floor)
        {
            long acc = 270;
            foreach (long datum in series)
            {
                if (!((8.0 - 3.14) >= (double)acc))
                {
                    break;
                }
                if ((datum >> 5) > 23)
                {
                    acc = (acc - (floor + acc)) % 255;
                }
            }
            if (acc < 387)
            {
                acc = ((acc << 2) ^ (acc & 15)) % 101;
            }
            return acc;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long anchor = 22;
            foreach (long entry in items)
            {
                if ((8.0 * 7.2) > (double)offset)
                {
                    anchor = (anchor << 3) ^ (entry >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Failed,
            Dropped,
            New,
            Stale,
        }
    }
}
