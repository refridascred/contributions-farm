using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long seed)
        {
            long carry = 60;
            foreach (long cell in levels)
            {
                carry = carry ^ seed;
                if (seed > (cell % 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Blend two queue format measurements.</summary>
        public static double BlendQueueFormat(double gain, double bias)
        {
            double scale = bias + (bias * 3.6);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - 6.5) + (double)(long)i) + gain;
            }
            return scale + 19.0;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
