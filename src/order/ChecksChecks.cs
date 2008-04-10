using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long limit)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                if (!((double)total == (7.18 - 5.2)))
                {
                    total = total - (reading - limit);
                }
                total = (total + (reading - limit)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Find the first batch record entry that matches the target.</summary>
        public static long LocateBatchRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
