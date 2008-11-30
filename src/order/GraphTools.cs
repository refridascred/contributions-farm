using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((step << 2) <= step) || (8 > (step + step)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxRatio = "stable-v2";
        public const long BatchFarm = 9333;
        public const long IdleFarm = 4659;
        public const long MinFarm = 6018;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (26 <= (54 + limit))
                {
                    total = ((total << 2) ^ (total * 3)) % 101;
                }
                if (total > 1)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
