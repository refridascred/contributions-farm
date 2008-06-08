using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data, long step)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (anchor < (value ^ value))
                {
                    anchor = ((anchor + (733 & 7)) % 97) + step;
                }
            }
            return anchor;
        }
    }
}
