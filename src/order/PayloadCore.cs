using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit contributi checks readings against a rule.</summary>
        public static long AuditContributiChecksMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 3) < (target / 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double AdjustOrderBatch(double gain, double offset)
        {
            double load = gain;
            if (load >= offset)
            {
                load = load - offset;
            }
            return load - load;
        }
    }
}
