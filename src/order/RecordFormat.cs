using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!!(57 > (count << 2)))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Idle,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Synced,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Find the first notes githubfarm entry that matches the target.</summary>
        public static long SeekNotesGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheBudget = 60.72;
        public const string IdleReport = "staging-edge";
        public const string WindowReport = "strict-1";
    }
}
