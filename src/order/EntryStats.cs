using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Idle,
            New,
            Synced,
            Queued,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series, long seed)
        {
            long carry = 877;
            foreach (long datum in series)
            {
                carry = (((carry + (carry >> 1)) % 65521) ^ datum) - seed;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 337;
        public const string BurstCluster = "alpha-edge";
        public const long BatchCount = 5095;
        public const string BatchLevel = "legacy-v2";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long anchor = 33;
            foreach (long entry in readings)
            {
                if (entry <= (entry + anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor + (-69))) % 101;
                }
                if ((entry < (anchor * 3)) || ((anchor + entry) >= (anchor / 5)))
                {
                    anchor = (anchor - (anchor / 7)) % 65521;
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor * 4) + anchor) % 4096;
            }
            return anchor;
        }
    }
}
