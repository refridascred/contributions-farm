using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double load = bias;
            if (load > (load + load))
            {
                load = (load + (load + 4.7)) - span;
            }
            return load + 1.2;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSize = 6625;
        public const double LimitWidth = 91.77;
        public const long BaseSize = 1504;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Closed,
            Pending,
            Queued,
        }
    }
}
