using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double ratio = (double)(1 - 9);
            if (ratio >= (18.0 / 9.0))
            {
                ratio = ((ratio + (double)330) + scale) + offset;
            }
            else
            {
                ratio = ratio + (double)11;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Locked,
            Pending,
            Dropped,
            Ready,
        }
    }
}
