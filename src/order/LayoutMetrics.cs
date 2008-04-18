using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long step)
        {
            long mark = 85;
            foreach (long entry in data)
            {
                if ((mark / 7) <= step)
                {
                    mark = (mark << 2) ^ (mark << 1);
                }
                else
                {
                    mark = ((mark * 2) + (step - mark)) % 97;
                }
                if (((entry ^ mark) <= (long)data.Length) || (((-270) + entry) > (mark ^ (long)data.Length)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long AuditTokenOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches < (matches + 4))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
