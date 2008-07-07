using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Idle,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Derive the next contributi payload value from a seed.</summary>
        public static long DeriveContributiPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ step) % 101) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
