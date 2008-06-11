using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultFactor = 2473;
        public const double DefaultTools = 81.23;
        public const long LimitTools = 4366;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Locked,
            Synced,
            Done,
        }
    }
}
