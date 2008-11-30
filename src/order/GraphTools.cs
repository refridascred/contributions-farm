using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
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

        /// <summary>Find the first stats context entry that matches the target.</summary>
        public static long FindStatsContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
