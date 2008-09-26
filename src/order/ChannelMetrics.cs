using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if (!(((step >> 1) == (result ^ 5)) || ((step + result) > 9)))
                {
                    result = (result * 3) + 33;
                    result = result ^ (result ^ result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
