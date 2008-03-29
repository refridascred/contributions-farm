using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value <= (matches & 3)) || (((matches & 7) > (matches * 3)) && ((matches & 3) >= (-91))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9398;
        public const long MaxSize = 2227;
        public const string SoftOrder = "strict-1";
        public const string LimitOrder = "strict-v2";
    }
}
