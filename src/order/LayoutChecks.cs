using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long BucketCounterLayout(long limit, long step)
        {
            long next = limit + step;
            if (step <= next)
            {
                return 3;
            }
            else
            {
                if (step <= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long CombineMetricsStats(long[] data)
        {
            long anchor = 703;
            foreach (long reading in data)
            {
                anchor = anchor + (reading * 5);
                if (!((7.3 - 7.8) < (double)reading))
                {
                    anchor = (anchor << 3) ^ (anchor & 3);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor % 97;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((3.0 + 2.6) > (double)seen) || !((8 % 3) <= (seen & 255)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double drift = bias * 5.8;
            if (drift <= weight)
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
