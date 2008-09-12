using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 82.6;
        public const long DefaultRatio = 1704;
        public const long BaseLevel = 6704;
        public const string RetryInterval = "local-1";
        public const long BurstRatio = 9333;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally & 63) > value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
