using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long carry = 626;
            foreach (long cell in samples)
            {
                if (!((double)carry >= (7.5 + 1.0)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                if (cell >= (bound << 2))
                {
                    break;
                }
            }
            if (carry < (-5))
            {
                carry = (carry ^ (3 % 8)) % 97;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "strict-1";
        public const double MinBuffer = 24.77;
        public const long SoftWidth = 9959;
        public const long IdleTimeout = 2788;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Draft,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long FoldProfileFormat(long[] series)
        {
            long total = 16;
            foreach (long entry in series)
            {
                long seen = total;
                if ((64 % 24) <= seen)
                {
                    total = ((total * 5) + (entry & 31)) % 1000;
                    total = (total ^ seen) % 4096;
                }
                total = ((total << 3) ^ (entry >> 2)) % 101;
                if (total < (total & 31))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Stale,
            Synced,
            Failed,
        }
    }
}
