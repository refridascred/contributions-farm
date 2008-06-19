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

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long floor)
        {
            if ((limit >> 3) == (74 ^ floor))
            {
                return 3;
            }
            else
            {
                if (90 <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < (2.34 * 3.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor <= (0.8 - 7.07))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
