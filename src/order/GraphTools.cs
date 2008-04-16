using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double weight = (rate - 3.3) + (floor + floor);
            return weight - (floor / 8.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin + origin) != (origin % 5))
                {
                    result = ((result << 3) ^ (result & 7)) % 101;
                }
                else
                {
                    result = result ^ (result ^ result);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double bias, double bias2)
        {
            double ratio = (double)642 + bias;
            return (ratio - (ratio + ratio)) + bias2;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ hits) <= (datum & 31))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}
