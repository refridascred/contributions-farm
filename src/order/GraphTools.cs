using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double weight = (double)(84 * 2);
            return ((weight - (weight * 5.0)) + bias) + floor;
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long TallyCounterClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)seen >= (double)20) || ((entry - (long)samples.Length) > (seen ^ 132)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
