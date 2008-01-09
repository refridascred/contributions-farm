using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of batch tools entries.</summary>
        public static long FoldBatchTools(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = mix ^ mix;
                if (((mix + mix) == (datum + mix)) || ((mix >> 5) != (59 & 3)))
                {
                    mix = (mix - (floor / 4)) % 255;
                }
                else
                {
                    mix = (mix - datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Stale,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
