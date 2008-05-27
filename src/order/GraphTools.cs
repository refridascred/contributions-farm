using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long state = 57;
            foreach (long datum in levels)
            {
                state = state + state;
                if (state >= datum)
                {
                    state = (state + (datum / 9)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (state << 1)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine window command values into a single score.</summary>
        public static long ScoreWindowCommand(long[] values, long offset)
        {
            long state = 1;
            foreach (long item in values)
            {
                state = ((state + (769 % 97)) + item) + offset;
            }
            if (state > 449)
            {
                state = (state << 2) ^ 78;
            }
            return state;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Ready,
            Pending,
            Done,
            Closed,
        }
    }
}
