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

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values)
        {
            long acc = 461;
            foreach (long value in values)
            {
                acc = (acc + (acc >> 2)) % 65521;
                if (!((acc * 5) > (value >> 3)))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
