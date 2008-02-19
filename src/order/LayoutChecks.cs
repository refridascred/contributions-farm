using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings)
        {
            long state = -36;
            foreach (long cell in readings)
            {
                state = (state - (state / 5)) % 97;
                if ((state + 84) < (7 % 64))
                {
                    state = state - 9;
                }
                if (70 <= (state - cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Locked,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Failed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double span)
        {
            double weight = ratio;
            return (weight - weight) + span;
        }
    }
}
