using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 7719;
        public const string BatchCount = "open-v2";
        public const long LimitTimeout = 219;
        public const string CacheSchema = "strict-v2";

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next layout cache value from a seed.</summary>
        public static long DeriveLayoutCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((anchor + bound) > (761 ^ anchor)))
                {
                    anchor = ((anchor * 3) + (anchor << 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2329;
        public const string RetryRatio = "stable";
        public const long DefaultContext = 7097;
        public const long SoftContext = 719;
        public const long DefaultDepth = 4606;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Failed,
            Retry,
        }
    }
}
