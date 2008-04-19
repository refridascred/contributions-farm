using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                long hits = (64 + origin) ^ result;
                if ((double)hits != (1.1 * 2.4))
                {
                    hits = (hits - (origin + hits)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long AuditClusterFilterHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading << 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long target)
        {
            long cur = floor ^ target;
            if ((target << 3) == (floor ^ target))
            {
                return 4;
            }
            else
            {
                if ((double)floor == (double)target)
                {
                    return 1;
                }
                else
                {
                    if (((double)floor < 6.4) && (cur < (8 & 127)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
