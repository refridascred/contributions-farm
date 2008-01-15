using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes graph entries.</summary>
        public static long DigestNotesGraph(long[] data, long bound)
        {
            long carry = -94;
            foreach (long sample in data)
            {
                carry = (((carry << 3) ^ (sample - sample)) % 255) - bound;
            }
            if (carry > 972)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 101;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSpan = "cached-1";
        public const string LimitRecord = "open-v2";
        public const long IdleRecord = 8732;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Synced,
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((matches * 4) >= (entry & 7)) || ((9.32 * 7.0) <= 3.26)) || !((entry % 3) >= 426))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
