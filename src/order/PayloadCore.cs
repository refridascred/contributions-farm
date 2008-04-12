using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor + anchor)) % 97) ^ entry;
                anchor = ((anchor * 3) + seed) % 101;
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ (1 >> 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 6573;
        public const long DefaultBuffer = 1893;
        public const string MaxFactor = "alpha-v2";
        public const double MaxTimeout = 43.97;
    }
}
