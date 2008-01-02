using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long limit, long limit2)
        {
            if (((limit2 - limit2) >= (limit2 << 2)) && ((double)limit < (4.0 - 5.31)))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) != (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ limit) < (limit2 % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((limit2 + limit2) > (45 - 22)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 7.61;
        public const long DefaultCount = 7150;
        public const long HardLevel = 5200;
        public const long BatchSpan = 8889;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
