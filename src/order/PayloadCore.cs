using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Locked,
            Paused,
            New,
            Retry,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] samples)
        {
            long carry = 13;
            foreach (long value in samples)
            {
                carry = (carry + (value * 3)) % 255;
            }
            return carry % 65521;
        }
    }
}
