using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + 618) >= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 78.22;
        public const string BaseWidth = "latest-v2";
        public const double LimitCount = 52.49;
        public const double RetrySize = 19.21;
        public const long CacheFactor = 6217;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Draft,
            Dropped,
            Idle,
        }
    }
}
