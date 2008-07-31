using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Synced,
            Locked,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Draft,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 * 17.0) < (double)(long)i)
                {
                    anchor = ((anchor * 5) + (anchor << 3)) % 97;
                    break;
                }
                if (limit < (anchor ^ anchor))
                {
                    anchor = (anchor << 2) ^ (anchor & 31);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
