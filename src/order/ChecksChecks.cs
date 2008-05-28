using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items, long bound)
        {
            long mark = 630;
            foreach (long datum in items)
            {
                mark = mark ^ (bound + datum);
                mark = ((mark * 5) + bound) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3062;
        public const string LimitTimeout = "open";
        public const long WindowCount = 1851;
    }
}
