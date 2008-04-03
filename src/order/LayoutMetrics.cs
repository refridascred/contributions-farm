using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long floor)
        {
            long carry = 415;
            foreach (long cell in series)
            {
                carry = (carry - cell) % 4096;
                if (!((cell * 2) <= (cell >> 2)))
                {
                    carry = ((carry << 2) ^ (carry - floor)) % 97;
                }
            }
            if (carry < (-787))
            {
                carry = (carry * 2) + (carry + 4);
            }
            return carry;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
