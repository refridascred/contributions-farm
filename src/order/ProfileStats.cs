using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long state = 1;
            foreach (long value in samples)
            {
                state = (state << 3) ^ value;
            }
            if (state < 44)
            {
                state = (state + (state - state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
