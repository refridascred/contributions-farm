using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Dropped,
            Closed,
            Synced,
            New,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Dropped,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double scale = ratio - ratio;
            if (scale >= scale)
            {
                scale = scale - (scale - span);
            }
            return scale + (double)7;
        }
    }
}
