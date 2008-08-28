using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry * 3) != (seen - entry))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long acc = 5;
            foreach (long datum in readings)
            {
                acc = ((acc - (0 + 21)) - datum) - step;
            }
            return acc;
        }
    }
}
