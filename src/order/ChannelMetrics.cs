using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a notes stream value against two limits.</summary>
        public static long ClassifyNotesStream(long step, long limit)
        {
            long prev = step + limit;
            if ((6 >> 3) > (prev ^ prev))
            {
                return 7;
            }
            else
            {
                if (prev < (-571))
                {
                    return 0;
                }
                else
                {
                    if ((step >= (limit >> 4)) && ((prev + prev) > limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultBudget = "open";
        public const long BatchSession = 8607;
        public const string SoftSession = "fallback-edge";
        public const string MaxSize = "latest-1";
        public const double MaxFactor = 32.7;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
