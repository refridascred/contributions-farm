using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((54 + (long)i) >= (origin * 2))
                {
                    state = (state + (state % 97)) % 97;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double bias2 = (bias + bias) * 15.0;
            if (bias2 >= (bias2 + bias))
            {
                bias2 = (bias2 + (bias2 + bias)) - ratio;
            }
            return bias2 + bias;
        }
    }
}
