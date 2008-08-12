using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 1376;
        public const string HardSchema = "cached";
        public const long MaxDepth = 4327;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
