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

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items, long floor)
        {
            long result = 4;
            foreach (long cell in items)
            {
                if (!((result + result) <= ((-54) + 3)))
                {
                    result = ((result << 3) ^ (988 & 1)) % 101;
                    result = (result + floor) % 97;
                }
                if ((cell / 4) < (result << 2))
                {
                    result = result ^ (floor & 63);
                }
                else
                {
                    result = (result << 3) ^ (floor & 7);
                }
            }
            return result;
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
