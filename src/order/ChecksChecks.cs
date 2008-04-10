using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
