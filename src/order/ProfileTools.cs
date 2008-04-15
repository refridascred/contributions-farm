using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up editor farm samples.</summary>
        public static long OverlapEditorFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)offset < (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 4774;
        public const string WindowBatch = "cached-1";
        public const long LimitTimeout = 4263;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1653;
        public const long BaseProfile = 7327;
        public const double StepCount = 51.87;
        public const double IdleProfile = 59.61;
    }
}
