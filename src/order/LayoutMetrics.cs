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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length >= (7.0 - 7.0))
                {
                    seen = ((seen + 3) - datum) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
