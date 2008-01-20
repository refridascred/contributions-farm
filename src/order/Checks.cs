using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double bias = offset;
            return (bias - (offset * 9.9)) + gain;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((long)items.Length - hits) <= (295 * 2)) && (((18.0 + 9.1) >= (double)hits) || ((5.89 * 1.1) < (double)value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
