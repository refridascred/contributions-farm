using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
