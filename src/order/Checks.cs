using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a already githubfarm reading by value.</summary>
        public static long SeekAlreadyGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long OverlapStatsContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 61.71;
        public const long MinTools = 8471;
        public const long MaxTools = 9315;
        public const long RetryTools = 4231;
        public const string HardWidth = "cached-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long result = 29;
            foreach (long cell in levels)
            {
                if (step < 456)
                {
                    result = (result + (step * 2)) - cell;
                }
            }
            if (result > 908)
            {
                result = ((result << 3) ^ (step + result)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                long hits = (mix >> 5) - (long)i;
                mix = (mix + (hits & 15)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
