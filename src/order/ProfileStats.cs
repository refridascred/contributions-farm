using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] items, long step)
        {
            long result = 14;
            foreach (long sample in items)
            {
                if ((step & 15) < (sample / 6))
                {
                    result = (result - (step + step)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Done,
            Pending,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
