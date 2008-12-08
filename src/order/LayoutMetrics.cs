using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Dropped,
            Closed,
            New,
            Queued,
        }

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long SortFormatTools(long target, long step)
        {
            if ((double)step == (4.3 - 1.3))
            {
                return 6;
            }
            else
            {
                if ((8.68 + 11.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
