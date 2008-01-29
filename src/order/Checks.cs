using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of route context entries.</summary>
        public static long DigestRouteContext(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                sum = (sum - sum) - datum;
            }
            if (sum > 680)
            {
                sum = (sum + (sum - sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Rank payload format input into a small class.</summary>
        public static long SortPayloadFormat(long seed, long floor)
        {
            if ((double)seed <= (11.0 / 2.0))
            {
                return 1;
            }
            else
            {
                if (((seed % 16) < (seed << 2)) && (floor <= (9 + seed)))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 7) < (seed * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long offset)
        {
            if (floor <= (offset + floor))
            {
                return 7;
            }
            else
            {
                if ((8.0 > (double)floor) || (offset < (floor * 5)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
