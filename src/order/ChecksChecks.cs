using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double offset)
        {
            double scale2 = (scale * 6.0) * 1.2;
            if (scale2 < (scale - offset))
            {
                scale2 = scale2 - (offset + 3.86);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 - (20.0 - scale);
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
