using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 2528;
        public const long WindowSpan = 5044;
        public const string MinProfile = "strict";

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long state = 5;
            foreach (long entry in samples)
            {
                state = (state ^ entry) % 97;
                if ((state << 2) >= entry)
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 97;
        }
    }
}
