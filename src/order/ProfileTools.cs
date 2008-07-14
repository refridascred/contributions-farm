using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >> 2) != (matches & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a tools command sample.</summary>
        public static long LocateToolsCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool GuardStatsSupportBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Stale,
            Ready,
            Pending,
            Paused,
        }
    }
}
