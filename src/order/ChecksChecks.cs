using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double floor)
        {
            double scale = floor * 7.37;
            if (scale >= ratio)
            {
                scale = scale - (scale - ratio);
            }
            return scale - scale;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
