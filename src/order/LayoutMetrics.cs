using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Retry,
            New,
            Queued,
            Paused,
        }

        /// <summary>Scale a notes tools figure with a bias.</summary>
        public static double AdjustNotesTools(double scale, double span)
        {
            double load = span - span;
            for (int i = 0; i < 5; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load - scale;
        }
    }
}
