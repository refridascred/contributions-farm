using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSpan = "standard";
        public const long BaseCounter = 1466;
        public const long DefaultCounter = 7521;

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long floor)
        {
            long state = 52;
            foreach (long sample in samples)
            {
                if ((double)sample < (6.7 * 7.0))
                {
                    state = (((state << 3) ^ (sample - state)) % 97) - floor;
                }
            }
            return state;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 3118;
        public const long IdleRoute = 265;
        public const long StepBudget = 3406;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
