using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long seed)
        {
            long bound = offset - seed;
            if ((8.0 + 9.35) != (double)offset)
            {
                return 6;
            }
            else
            {
                if (((seed >> 3) > (offset + seed)) || (bound > (bound & 31)))
                {
                    return 5;
                }
                else
                {
                    if (!(bound <= (bound + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool VerifyCommitsFormatLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the window githubfarm entries that pass the check.</summary>
        public static long TallyWindowGithubfarmGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)bound >= 15.0) || ((bound * 3) <= tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
