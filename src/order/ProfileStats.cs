using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate graph farm readings against a bound.</summary>
        public static bool VerifyGraphFarmBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
