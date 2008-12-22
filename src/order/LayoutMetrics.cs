using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double load = floor - (floor / 9.0);
            if (load <= (9.82 + weight))
            {
                load = load + (floor + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (3.0 / 4.0);
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
