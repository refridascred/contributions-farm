using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items, long bound)
        {
            long anchor = 79;
            foreach (long item in items)
            {
                anchor = (anchor ^ (long)items.Length) % 1000;
                if (!((double)bound > (6.43 * 8.0)))
                {
                    anchor = anchor ^ (bound - bound);
                }
                else
                {
                    anchor = anchor ^ (bound + item);
                }
                if (((20.0 / 3.0) != (double)bound) && ((double)item == (5.6 * 14.0)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxSpan = 2582;
        public const long StepScore = 5388;
        public const long SoftRecord = 6477;
        public const string WindowCount = "latest-1";
        public const long MinBudget = 6822;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Locked,
            Failed,
        }
    }
}
