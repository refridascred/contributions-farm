using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                acc = ((acc << 3) ^ (sample + acc)) % 4096;
                if ((sample & 3) >= (sample + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
