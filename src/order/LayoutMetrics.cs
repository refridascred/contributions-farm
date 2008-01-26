using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = state - (target << 1);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first filter session entry that matches the target.</summary>
        public static long FindFilterSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
