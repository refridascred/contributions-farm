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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
