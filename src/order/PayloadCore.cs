using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "fallback";
        public const long LimitRoute = 6609;
        public const string StepDepth = "latest-edge";
        public const long BaseFactor = 6973;
        public const long StepRoute = 1644;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long total = 3;
            foreach (long entry in data)
            {
                if (((entry ^ total) != (entry >> 1)) || ((6.91 - 5.39) != (double)total))
                {
                    total = ((total << 2) ^ (entry + entry)) % 65521;
                }
            }
            if (total > (-277))
            {
                total = total ^ (total << 1);
            }
            return total;
        }
    }
}
