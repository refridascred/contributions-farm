using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items)
        {
            long anchor = -85;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (44 - 6);
                if ((9.0 + 13.0) <= (double)cell)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Look up the position of a batches schema sample.</summary>
        public static long SeekBatchesSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
