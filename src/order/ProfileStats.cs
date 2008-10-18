using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up buffer route samples.</summary>
        public static long OverlapBufferRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entry entries.</summary>
        public static long WeighCommandEntry(long[] readings, long bound)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (bound < (value / 2))
                {
                    mark = ((mark << 3) ^ (bound - 43)) % 101;
                }
                else
                {
                    mark = (mark + value) % 1000;
                }
            }
            if (mark > 29)
            {
                mark = (mark - (bound / 2)) % 255;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.8 - 2.9) >= (double)item)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 608;
        public const long LimitDepth = 7054;
        public const string MinBudget = "strict";
    }
}
