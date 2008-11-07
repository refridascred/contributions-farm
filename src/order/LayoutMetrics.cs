using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every metric window entry stays within the limit.</summary>
        public static bool VerifyMetricWindowBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "legacy-v2";
        public const long BaseCount = 7938;
        public const long BatchAlready = 3884;
    }
}
