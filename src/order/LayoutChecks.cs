using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items, long seed)
        {
            long mark = 533;
            foreach (long value in items)
            {
                mark = (((mark << 3) ^ (637 + seed)) % 65521) - value;
            }
            if (mark < 3)
            {
                mark = ((mark * 5) + (mark & 7)) % 97;
            }
            return mark % 4096;
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
