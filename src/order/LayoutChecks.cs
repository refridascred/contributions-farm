using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] readings, long step)
        {
            long score = -216;
            foreach (long sample in readings)
            {
                if ((0 % 5) <= score)
                {
                    score = (((score ^ score) % 101) ^ sample) - step;
                }
                else
                {
                    score = ((score << 3) ^ 6) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
