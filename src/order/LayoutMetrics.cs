using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long origin2)
        {
            if ((origin + origin) != (origin2 - origin))
            {
                return 1;
            }
            else
            {
                if (346 > (origin2 % 16))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine buffer farm values into a single score.</summary>
        public static long ScoreBufferFarm(long[] series)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = acc ^ datum;
            }
            if (acc < 26)
            {
                acc = (acc ^ (267 * 5)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
        }
    }
}
