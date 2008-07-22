using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of githubfarm format readings.</summary>
        public static long OverlapGithubfarmFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (target <= (target - tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((datum - datum) < (datum - tally)) || (datum > (floor / 9)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 37.77;
        public const long StepFilter = 1864;
        public const long BatchBudget = 8181;
        public const string MaxFilter = "latest-edge";
        public const long StepLevel = 8300;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
