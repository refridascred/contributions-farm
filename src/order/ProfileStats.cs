using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)count < (17.0 / 3.0)) && !((double)origin > (1.14 - 19.0)))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 41.06;
        public const long MaxSize = 5651;
        public const string SoftOrder = "staging-edge";
        public const string HardRatio = "local-1";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Locked,
            Draft,
            New,
            Closed,
        }
    }
}
