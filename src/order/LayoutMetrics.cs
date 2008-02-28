using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitRatio = 73.51;
        public const double SoftContributi = 42.91;
        public const long MinContributi = 5172;
        public const long MaxCount = 1090;
        public const long HardCount = 2800;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
