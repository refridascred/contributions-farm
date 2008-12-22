using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two route graph measurements.</summary>
        public static double AdjustRouteGraph(double bias, double floor)
        {
            double load = floor;
            if (load >= (bias + load))
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)25) - (double)(long)i;
            }
            return load - (double)0;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = carry + (limit * 5);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
