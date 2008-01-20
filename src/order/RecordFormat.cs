using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a editor graph counter forward.</summary>
        public static long StepEditorGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (((total * 3) + (total * 3)) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
