using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 56.36;
        public const long LimitInterval = 9850;
        public const long DefaultBatches = 1989;
        public const long MinBatches = 7467;

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long bound)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                anchor = (anchor + (bound & 7)) % 65521;
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (bound + (-1))) % 1000) - (long)i;
                    anchor = (anchor ^ ((long)samples.Length - entry)) % 4096;
                }
                anchor = (anchor * 5) + bound;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Failed,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "local";
        public const long BaseProfile = 4739;
        public const string WindowProfile = "cached-v2";
        public const string BurstRatio = "primary-1";
    }
}
