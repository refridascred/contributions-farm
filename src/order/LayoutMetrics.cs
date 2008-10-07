using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 4531;
        public const string BaseWindow = "strict-edge";
        public const long SoftWindow = 5127;
        public const long IdleWidth = 8235;
        public const long BatchWindow = 6555;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
