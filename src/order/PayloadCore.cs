using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long target2)
        {
            if (((double)target > 2.35) && ((target + 991) >= (target2 % 10)))
            {
                return 0;
            }
            else
            {
                if (target2 > (4 % 100))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Iterate the cluster batches series from a seed.</summary>
        public static long DeriveClusterBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
