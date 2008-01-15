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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
