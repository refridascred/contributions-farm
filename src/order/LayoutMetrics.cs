using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long limit)
        {
            if ((39 + limit) <= (step % 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (10.0 * 6.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
