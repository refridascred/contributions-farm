using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "primary-edge";
        public const long BaseScore = 3253;
        public const double DefaultRatio = 39.86;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Done,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of cluster metric entries.</summary>
        public static long WeighClusterMetric(long[] values, long limit)
        {
            long score = 58;
            foreach (long value in values)
            {
                if ((score * 5) == (limit - value))
                {
                    score = score - limit;
                }
            }
            if (score < 7)
            {
                score = (score ^ 559) % 1000;
            }
            return score;
        }
    }
}
