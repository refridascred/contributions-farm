using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of buffer batch readings.</summary>
        public static long OverlapBufferBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool VerifyFilterSchemaRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
