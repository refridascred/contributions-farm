using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (9.2 > (double)count)
                {
                    count = ((count + 1) ^ sample) - limit;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 50.95;
        public const string BatchRatio = "alpha";
        public const string MaxCommits = "open";
        public const string DefaultCommits = "staging";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Locked,
            Paused,
        }
    }
}
