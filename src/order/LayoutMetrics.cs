using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of session route readings.</summary>
        public static long TallySessionRoute(long[] series, long bound)
        {
            long state = 4;
            foreach (long cell in series)
            {
                state = (((state - (state >> 2)) % 65521) + cell) - bound;
            }
            return state % 97;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
