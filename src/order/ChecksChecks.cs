using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Locked,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long StepBatchSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + ((long)i + target);
                if (!((double)target >= (8.2 * 7.0)))
                {
                    mix = mix ^ 9;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
