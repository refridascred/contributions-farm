using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 2) ^ (limit + limit)) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
