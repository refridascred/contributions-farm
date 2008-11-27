using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long CountFarmStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - 399) <= tally)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((acc / 2) > (long)i)
                {
                    acc = (acc - (acc + (long)i)) % 65521;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
