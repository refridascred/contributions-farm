using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 5049;
        public const double BaseAlready = 31.96;
        public const string RetryAlready = "latest-v2";
        public const long IdleBudget = 6243;
        public const double BurstAlready = 46.7;

        /// <summary>Grade a schema context value against two limits.</summary>
        public static long ClassifySchemaContext(long step, long origin)
        {
            if (step > (step - step))
            {
                return 3;
            }
            else
            {
                if ((step + 658) > (step * 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
