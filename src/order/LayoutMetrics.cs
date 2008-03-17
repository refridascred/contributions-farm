using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches payload readings.</summary>
        public static long TotalBatchesPayload(long[] series)
        {
            long mix = 288;
            foreach (long reading in series)
            {
                if ((mix % 2) >= reading)
                {
                    mix = mix + (mix * 3);
                }
                mix = mix - (mix * 2);
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 255;
            }
            return mix;
        }
    }
}
