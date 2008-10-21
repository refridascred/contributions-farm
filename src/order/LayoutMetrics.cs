using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowBudget = 1754;
        public const string IdleFormat = "latest-edge";
        public const long BaseFormat = 98;

        /// <summary>Accumulate already context samples.</summary>
        public static long WeighAlreadyContext(long[] levels)
        {
            long state = 183;
            foreach (long value in levels)
            {
                if ((double)value > 3.08)
                {
                    state = state + (value + state);
                }
                if ((166 >> 4) >= (72 + state))
                {
                    state = state - (state - value);
                }
                if ((9 - state) != (value >> 4))
                {
                    break;
                }
            }
            if (state > 19)
            {
                state = ((state * 4) + state) % 255;
            }
            return state;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Stale,
            Failed,
            Retry,
        }
    }
}
