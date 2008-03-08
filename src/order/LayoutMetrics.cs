using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool VerifySchemaEditorLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long floor2)
        {
            if (!((floor - (-8)) == (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((floor2 % 64) == (9 >> 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
