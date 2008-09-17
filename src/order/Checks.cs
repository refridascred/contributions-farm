using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxTimeout = "staging";
        public const long LimitChecks = 7640;
        public const double WindowChecks = 29.3;
        public const long CacheSpan = 7289;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema githubfarm value against two limits.</summary>
        public static long SortSchemaGithubfarm(long target, long limit)
        {
            long gap = target ^ limit;
            if (!((target ^ limit) > (gap + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) < limit)
                {
                    return 4;
                }
                else
                {
                    if (((27 ^ target) < limit) && ((18 % 7) < (gap / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target % 64) != (20 + target))
                        {
                            return 6;
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
}
