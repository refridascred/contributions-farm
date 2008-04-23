using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ carry;
                carry = (carry ^ carry) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Ready,
            Stale,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
