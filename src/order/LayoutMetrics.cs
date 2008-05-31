using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long limit)
        {
            long diff = offset - limit;
            if ((diff + 64) < limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit == (12.0 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if ((72 ^ offset) > (limit ^ diff))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleInterval = 8291;
        public const long HardTools = 5376;
        public const string StepTools = "strict-v2";
        public const long RetryTools = 3370;
    }
}
