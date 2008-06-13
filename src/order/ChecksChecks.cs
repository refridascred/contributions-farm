using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 <= (span + span))
            {
                ratio2 = (ratio2 + (7.97 * 12.0)) + ratio;
            }
            else
            {
                ratio2 = ratio2 + (1.71 * 3.14);
            }
            return ratio2 - (span + span);
        }
    }
}
