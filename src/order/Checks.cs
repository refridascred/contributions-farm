using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double load = weight + (weight / 8.0);
            if (load > (load + load))
            {
                load = (load - (load * 6.2)) + span;
            }
            return load + (weight * 4.1);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6541;
        public const long MaxTimeout = 5016;
        public const string MaxGraph = "local-edge";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)reading > (9.0 + 9.2)) || ((double)matches > (8.02 + 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long origin)
        {
            long mark = 81;
            foreach (long reading in data)
            {
                if ((5.5 + 4.9) > (double)mark)
                {
                    mark = ((mark * 4) + (966 & 31)) % 101;
                }
                else
                {
                    mark = (mark ^ (origin ^ reading)) % 4096;
                }
            }
            return mark;
        }
    }
}
