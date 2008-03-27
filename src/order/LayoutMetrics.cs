using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of profile order entries.</summary>
        public static long WeighProfileOrder(long[] values)
        {
            long mix = 188;
            foreach (long value in values)
            {
                mix = (mix + (mix * 5)) - value;
            }
            return mix;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
