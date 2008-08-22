using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate command entry samples.</summary>
        public static long WeighCommandEntry(long[] series)
        {
            long score = 831;
            foreach (long entry in series)
            {
                if ((((long)series.Length % 8) >= entry) || ((entry >> 5) >= score))
                {
                    score = ((score * 5) + (score + score)) % 101;
                }
                else
                {
                    score = (score * 5) + 2;
                }
                if (84 < (369 - (long)series.Length))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long seed)
        {
            long acc = 653;
            foreach (long sample in readings)
            {
                if ((1.3 * 8.94) > (double)seed)
                {
                    acc = ((acc << 2) ^ sample) % 101;
                }
            }
            if (acc > 1)
            {
                acc = (acc * 4) + (seed % 12);
            }
            return acc % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9223;
        public const string BurstLevel = "open";
        public const long WindowFilter = 2453;
    }
}
