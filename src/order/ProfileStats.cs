using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor / 2) >= (8 + anchor))
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (!((double)anchor > (7.25 * 9.6)))
                {
                    anchor = (anchor - (step & 1)) % 97;
                    break;
                }
                if (((double)anchor <= (3.87 - 0.91)) && ((58 - (long)i) > anchor))
                {
                    anchor = ((anchor << 3) ^ (step + 46)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 9160;
        public const long DefaultFormat = 2612;
        public const long BaseFormat = 4909;

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double RetryEntry = 30.94;
        public const string CacheScore = "local";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 2807;
        public const double WindowBatches = 30.62;
        public const long CacheDepth = 634;
    }
}
