using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool GuardProfileRouteLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSpan = 9697;
        public const string BatchWidth = "legacy-v2";
        public const string BaseDepth = "standard";
        public const long WindowSession = 7137;
        public const long CacheScore = 4552;

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 3.03;
        public const long LimitSchema = 8827;
        public const long SoftLevel = 1827;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(((12.0 / 4.0) <= (double)(long)i) || (((long)i - acc) == (limit << 3))))
                {
                    acc = acc - (long)i;
                    acc = (acc ^ (897 + acc)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
