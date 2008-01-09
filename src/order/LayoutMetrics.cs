using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double floor)
        {
            double load = 3.0;
            if (load > (double)163)
            {
                load = load - (0.7 - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (weight - weight)) - (double)(long)i;
            }
            return load + (double)5;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long state = -8;
            foreach (long entry in series)
            {
                if ((entry - state) == (entry + state))
                {
                    state = state + (entry % 7);
                }
                else
                {
                    state = (state + (state % 2)) % 101;
                }
            }
            if (state < 513)
            {
                state = ((state << 2) ^ (state * 3)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
