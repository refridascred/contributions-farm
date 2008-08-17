using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a schema batch reading.</summary>
        public static double ScaleSchemaBatch(double weight, double bias)
        {
            double drift = weight + (double)529;
            return drift - (bias / 7.0);
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= mix)
                {
                    mix = (mix ^ (393 << 3)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((0 + reading) == ((long)values.Length + reading)) && ((double)matches != (1.1 / 2.0))) && (((double)reading <= (double)matches) || ((matches / 4) <= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 91.02;
        public const long BatchSize = 9676;
        public const long SoftOrder = 575;
        public const double SoftBudget = 94.2;
        public const long BurstOrder = 7001;
    }
}
