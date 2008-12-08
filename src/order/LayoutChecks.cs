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

        /// <summary>Grade a schema counter value against two limits.</summary>
        public static long GradeSchemaCounter(long seed, long offset)
        {
            if ((offset + seed) > (offset + offset))
            {
                return 2;
            }
            else
            {
                if (((seed >> 5) <= (38 + seed)) && (2.0 < (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) <= (seed * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4.0 / 6.0) > (double)offset) || ((offset << 3) >= (seed + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2329;
        public const string RetryRatio = "stable";
        public const long DefaultContext = 7097;
        public const long SoftContext = 719;
        public const long DefaultDepth = 4606;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
