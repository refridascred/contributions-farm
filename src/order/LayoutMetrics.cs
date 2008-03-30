using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
