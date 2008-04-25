using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long MeasureStreamSchemaOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches == (double)882)
                {
                    matches = ((matches + 3) ^ cell) - step;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Dropped,
            Paused,
        }
    }
}
