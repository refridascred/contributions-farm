using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every farm metric entry stays within the limit.</summary>
        public static bool ValidateFarmMetricLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next profile metrics value from a seed.</summary>
        public static long StepProfileMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
