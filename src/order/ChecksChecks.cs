using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 3) + bound;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
