using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two githubfarm checks measurements.</summary>
        public static double BlendGithubfarmChecks(double rate, double span)
        {
            double load = span;
            if (load > (0.8 / 7.0))
            {
                load = load - span;
            }
            else
            {
                load = load + (load - rate);
            }
            return load + rate;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long lane = floor ^ limit;
            if ((double)floor == (double)lane)
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (lane ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (limit - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const long BurstDepth = 4960;
        public const double IdleSpan = 78.0;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Closed,
            Dropped,
        }
    }
}
