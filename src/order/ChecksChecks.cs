using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Done,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long ScoreSessionGithubfarm(long[] series)
        {
            long acc = 95;
            foreach (long value in series)
            {
                acc = (acc << 3) ^ (value + acc);
            }
            if (acc < 3)
            {
                acc = ((acc * 5) + (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}
