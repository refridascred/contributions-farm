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

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if ((cell + 499) <= score)
                {
                    score = score ^ (score - score);
                }
                else
                {
                    score = score - cell;
                }
            }
            return score % 97;
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
