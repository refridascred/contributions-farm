using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6744;
        public const long BurstDepth = 848;
        public const string WindowSchema = "cached";
        public const string MaxSize = "standard";

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
