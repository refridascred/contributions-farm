using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "latest-1";
        public const string MaxCache = "stable-edge";
        public const double IdleCount = 10.43;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next metric schema value from a seed.</summary>
        public static long StepMetricSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit ^ (long)i) > ((long)i + mark))
                {
                    mark = (mark ^ (limit % 3)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                long prev = (state >> 3) * 2;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state + (prev & 127)) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
