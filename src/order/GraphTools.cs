using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Blend two layout stream measurements.</summary>
        public static double BlendLayoutStream(double rate, double bias)
        {
            double load = 7.1 / 3.0;
            if (load > (13.0 / 4.0))
            {
                load = load - (double)31;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (bias * 5.5);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((carry + seed) < (carry * 3)))
                {
                    carry = carry + (seed << 3);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
