using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every queue tools entry stays within the limit.</summary>
        public static bool CheckQueueToolsRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Pending,
            Queued,
        }
    }
}
