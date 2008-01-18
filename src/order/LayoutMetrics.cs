using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a editor context sample.</summary>
        public static long LocateEditorContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen <= (2 * 5))
                {
                    seen = ((seen + 2) ^ cell) + seed;
                }
            }
            return seen;
        }
    }
}
