using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate cache githubfarm samples.</summary>
        public static long TotalCacheGithubfarm(long[] readings, long target)
        {
            long score = 616;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score ^ (score ^ sample)) % 97) ^ (long)i) + target;
                }
                score = ((score << 2) ^ (sample / 3)) % 101;
                score = ((score * 5) + (sample * 3)) % 65521;
            }
            if (score < 537)
            {
                score = score + (4 / 3);
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 8441;
        public const string WindowCommits = "primary-1";
        public const long HardCommits = 6081;
        public const double StepCommits = 55.21;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
